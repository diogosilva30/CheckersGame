using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public class Game
    {
        #region PublicEvents
        public event Methods2Points AIMove;
        public event Methods1Point PieceNowQueen;
        public event MethodsNoParamaters GameIsOver;
        public event Methods1Point Piece_Eaten;
        #endregion

        #region PublicProperties
        public enum GAMEMODE { PC = 1, PVP = 2, NETWORK = 3 };
        public GAMEMODE GameMode { get; set; }
        public Board Board { get; set; }
        public List<Player> Players { get; private set; }
        public Player Winner { get; set; }
        public bool IsPaused { get; set; }
        public bool HasEaten { get; set; }
        public bool IsGameOver
        {
            get { return isgameover; }
            set
            {
                isgameover = value;
                if (value)
                {

                    GameIsOver?.Invoke();
                }
            }
        }
        #endregion

        #region PrivateVariables
        private bool isgameover;
        #endregion


        public Game()
        {
            IsGameOver = false;
            IsPaused = false;
            Players = new List<Player>();
            Board = new Board();
            Winner = null;
            HasEaten = false;
            Board.EatPiece += Board_EatPiece;
           
        }


        private void Board_EatPiece(Point p)
        {

            Piece Piece_to_Eat = new Piece();

            Board.BoardMatrix[p.X,p.Y] = Board.EMPTY;
            foreach (Player player in Players)
            {
                if (!player.IsTurn)
                {
                    Piece_to_Eat = player.FindPiece(p);
                    player.Pieces.Remove(Piece_to_Eat);
                }

            }
            Piece_Eaten?.Invoke(p);

           
            HasEaten = true;
        }

        public void GiveUp()
        {
            if (GameMode==GAMEMODE.PC)
            {
                Players[0].N_Left++;
                Winner = Players[1];
            }
            else
            {
                foreach (Player player in Players)
                {
                    if (player.IsTurn)
                    {
                        GetPlayerPlaying().N_Left++;
                    }
                    else
                    {
                        Winner = player;
                    }
                }
            }
            
            IsGameOver = true;
            
        }
        
        public void UpdatePieces(Point origin, Point destination)
        {
            foreach (Player p in Players)
            {
                p.UpdatePiece(origin, destination);
            }
        }
        public bool IsPlayPossible(Point origin, Point destination, string color)
        {
            if(Board.SetPosition(origin, destination, color))
            {
                UpdatePieces(origin, destination);
                return true;
            }
            return false;
        }

        public void AddPlayer(Player p)
        {
            if (Players.Count < 2)
            {
                Players.Add(p);
            }
        }

        public void SwitchTurn()
        {
            if (Players[0].IsTurn)
            {
                Players[0].IsTurn = false;
                Players[1].IsTurn = true;

            }
            else if (Players[1].IsTurn)
            {
                Players[1].IsTurn = false;
                Players[0].IsTurn = true;
            }
            
        }
        public bool MakeAIMove(ref bool extra_movement)
        {
            bool rtn = false;
            if (!(GetPlayerPlaying() is VirtualPlayer))
            {
                return rtn;
            }
            Move currentMove = (GetPlayerPlaying() as VirtualPlayer).GetMove(Board, GetTurnColor().Substring(0, 1));
            if (currentMove!=null)
            {
                if (IsPlayPossible(currentMove.origin.Position, currentMove.destination.Position, GetTurnColor().Substring(0, 1)))
                {
                    AIMove?.Invoke(currentMove.origin.Position, currentMove.destination.Position);
                    UpdatePieces(currentMove.origin.Position, currentMove.destination.Position);
                    rtn=true;
                }
            }
            if (HasEaten)
            {
                if (ExtraMov(currentMove.destination.Position, GetTurnColor().Substring(0,1)))
                {
                    extra_movement = true;
                }
            }
            CheckWinner();
            if (Winner!=null)
            {
                IsGameOver = true;
            }
            CheckQueen(GetTurnColor().Substring(0,1), currentMove.destination.Position);

            return rtn;
        }
        public string GetTurnColor()
        {
            string color = "";
            if (Players[0].IsTurn)
            {
                if (Players[0].Pieces[0].Color == Color.White)
                {
                    color = "White";
                }
                else
                {
                    color = "Blue";
                }
            }
            else
            {
                if (Players[1].Pieces[0].Color == Color.White)
                {
                    color = "White";
                }
                else
                {
                    color = "Blue";
                }
            }
            return color;
        }

        public Piece FindPiece(Point MatrixCoordinates)
        {
            Piece piece = new Piece();
            foreach (Player p in Players)
            {
                if (p.IsTurn)
                {
                    piece = p.FindPiece(MatrixCoordinates);
                }
            }
            return piece;
        }
        
        public List<Piece> GetOpponentPieces()
        {
            foreach (Player player in Players)
            {
                if (!player.IsTurn)
                {
                    return player.Pieces;
                }
            }
            return new List<Piece>();
        }

        public bool ExtraMov(Point new_origin, string colour)
        {
            List<Piece> Opposite = GetOpponentPieces();
            List<Point> Positions = new List<Point>();

            int NextPosition = (colour == "W") ? -2 : 2;

            Positions.Add(new Point(new_origin.X + 2, new_origin.Y + NextPosition));
            Positions.Add(new Point(new_origin.X - 2, new_origin.Y + NextPosition));

            if (FindPiece(new_origin).IsQueen)
            {
                Positions.Add(new Point(new_origin.X + 2, new_origin.Y - NextPosition));
                Positions.Add(new Point(new_origin.X - 2, new_origin.Y - NextPosition));
            }

            for (int i = 0; i < Positions.Count; i++)
            {
                if (Positions[i].X >= 0 && Positions[i].X < 8 &&
                    Positions[i].Y >= 0 && Positions[i].Y < 8)
                {
                    if (Board.BoardMatrix[Positions[i].X, Positions[i].Y] == Board.EMPTY)
                    {
                        foreach (Player player in Players)
                        {
                            if (!player.IsTurn)
                            {
                                int x = 0, y = 0;
                                if (player.CanBeEaten(new_origin, Positions[i], ref x, ref y))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

            }
            return false;
        }


        public void CheckWinner()
        {
            if (Players[0].Pieces.Count==0)
            {
                Winner = Players[1];
            }

            if (Players[1].Pieces.Count == 0)
            {
                Winner = Players[0];
            }
        }

        public Player GetPlayerPlaying()
        {
            foreach (Player player in Players)
            {
                if (player.IsTurn)
                {
                    return player;
                }
            }

            return new RealPlayer();
        }

        public void CheckQueen(string colour, Point destination)
        {
            if (Board.CheckQueen(colour, destination))
            {
                foreach (Player player in Players)
                {
                    if (player.IsTurn)
                    {
                        player.FindPiece(destination).IsQueen = true;
                        PieceNowQueen?.Invoke(destination);
                        break;
                    }
                }
            }
        }
        public void SetDefaultState()
        {
            Board.SetDefaultState();
            foreach (Player player in Players)
            {
                player.SetPiecesDefaultState();
            }

        }
    }


}
