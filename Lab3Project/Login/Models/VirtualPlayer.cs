using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LabProject
{
    public class VirtualPlayer : Player
    {
        public VirtualPlayer()
        {
            Username = "PC";
            Foto = Properties.Resources.user_icon;
            LoadInfo();

        }
        public void LoadInfo()
        {
            try
            {
                StreamReader sr = new StreamReader("PC.txt");
                string[] info = sr.ReadLine().Split(';');
                N_Games = Convert.ToInt32(info[0]);
                N_Left = Convert.ToInt32(info[1]);
                N_Losts = Convert.ToInt32(info[2]);
                N_Wins = Convert.ToInt32(info[3]);
            }
            catch (FileNotFoundException)
            { }
        }
        public Move GetMove(Board currentBoard,string AIColour)
        {
            List<Move> avaliableMoves = GetAvaliableMoves(currentBoard, AIColour);
            avaliableMoves.Shuffle();
            if (avaliableMoves.Count < 1)
                return null;
            return avaliableMoves[0];
        }

        public List<Move> GetAvaliableMoves(Board currentBoard, string AIColour)
        {
            List<Move> avaliableMoves = new List<Move>();

            List<Move> jumpMoves = currentBoard.CheckJumps(AIColour);
            if (jumpMoves.Count > 0)
            {
                return jumpMoves;
            }

            foreach (Piece p in Pieces)
            {
                avaliableMoves.AddRange(CheckForMoves(p, currentBoard, AIColour));
            }
            return avaliableMoves;
        }

        public List<Move> CheckForMoves(Piece piece, Board currentBoard, string AIColour)
        {
            int QUEEN, NORMAL_PIECE, OPPOSITE_QUEEN, OPPOSITE_NORMAL_PIECE;
            if (AIColour.Equals("B"))
            {
                QUEEN = Board.BLUE_QUEEN;
                NORMAL_PIECE = Board.BLUE_PIECE;
                OPPOSITE_QUEEN = Board.WHITE_QUEEN;
                OPPOSITE_NORMAL_PIECE = Board.WHITE_PIECE;
            }
            else
            {
                QUEEN = Board.WHITE_QUEEN;
                NORMAL_PIECE = Board.WHITE_PIECE;
                OPPOSITE_QUEEN = Board.BLUE_QUEEN;
                OPPOSITE_NORMAL_PIECE = Board.BLUE_PIECE;
            }

            List<Move> moves = new List<Move>();
            if (currentBoard.GetState(piece.Position.X, piece.Position.Y) == QUEEN)
            {
                if ((currentBoard.GetState(piece.Position.X - 1, piece.Position.Y - 1) == OPPOSITE_NORMAL_PIECE) || (currentBoard.GetState(piece.Position.X - 1, piece.Position.Y - 1) == OPPOSITE_QUEEN))
                {
                    if (currentBoard.GetState(piece.Position.X - 2, piece.Position.Y - 2) == Board.EMPTY)
                        moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X - 2, piece.Position.Y - 2)));
                }
                if ((currentBoard.GetState(piece.Position.X - 1, piece.Position.Y + 1) == OPPOSITE_NORMAL_PIECE) || (currentBoard.GetState(piece.Position.X - 1, piece.Position.Y + 1) == OPPOSITE_QUEEN))
                {
                    if (currentBoard.GetState(piece.Position.X - 2, piece.Position.Y + 2) == Board.EMPTY)
                        moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X - 2, piece.Position.Y + 2)));
                }
                if ((currentBoard.GetState(piece.Position.X + 1, piece.Position.Y - 1) == OPPOSITE_NORMAL_PIECE) || (currentBoard.GetState(piece.Position.X + 1, piece.Position.Y - 1) == OPPOSITE_QUEEN))
                {
                    if (currentBoard.GetState(piece.Position.X + 2, piece.Position.Y - 2) == Board.EMPTY)
                        moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X + 2, piece.Position.Y - 2)));
                }
                if ((currentBoard.GetState(piece.Position.X + 1, piece.Position.Y + 1) == OPPOSITE_NORMAL_PIECE) || (currentBoard.GetState(piece.Position.X + 1, piece.Position.Y + 1) == OPPOSITE_QUEEN))
                {
                    if (currentBoard.GetState(piece.Position.X + 2, piece.Position.Y + 2) == Board.EMPTY)
                        moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X + 2, piece.Position.Y + 2)));
                }


                if (currentBoard.GetState(piece.Position.X - 1, piece.Position.Y - 1) == Board.EMPTY)
                    moves.Add(new Move(new Piece(piece.Position.X , piece.Position.Y), new Piece(piece.Position.X-1, piece.Position.Y - 1)));

                if (currentBoard.GetState(piece.Position.X - 1, piece.Position.Y + 1) == Board.EMPTY)
                    moves.Add(new Move(new Piece(piece.Position.X , piece.Position.Y), new Piece(piece.Position.X-1, piece.Position.Y + 1)));

                if (currentBoard.GetState(piece.Position.X + 1, piece.Position.Y - 1) == Board.EMPTY)
                    moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X + 1, piece.Position.Y - 1)));

                if (currentBoard.GetState(piece.Position.X + 1, piece.Position.Y + 1) == Board.EMPTY)
                    moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X + 1, piece.Position.Y + 1)));
            }


            else if (currentBoard.GetState(piece.Position.X, piece.Position.Y) == NORMAL_PIECE)
            {
                if ((currentBoard.GetState(piece.Position.X + 1, piece.Position.Y +1) == OPPOSITE_NORMAL_PIECE) || (currentBoard.GetState(piece.Position.X + 1, piece.Position.Y + 1) == OPPOSITE_QUEEN))
                {
                    if (currentBoard.GetState(piece.Position.X + 2, piece.Position.Y + 2) == Board.EMPTY)
                        moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X + 2, piece.Position.Y + 2)));
                }

                if ((currentBoard.GetState(piece.Position.X -1, piece.Position.Y + 1) == OPPOSITE_NORMAL_PIECE) || (currentBoard.GetState(piece.Position.X - 1, piece.Position.Y + 1) == OPPOSITE_QUEEN))
                {
                    if (currentBoard.GetState(piece.Position.X - 2, piece.Position.Y + 2) == Board.EMPTY)
                        moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X-2 , piece.Position.Y + 2)));
                }

                if (currentBoard.GetState(piece.Position.X + 1, piece.Position.Y + 1) == Board.EMPTY)
                    moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X+1, piece.Position.Y + 1)));
                if (currentBoard.GetState(piece.Position.X - 1, piece.Position.Y + 1) == Board.EMPTY)
                    moves.Add(new Move(new Piece(piece.Position.X, piece.Position.Y), new Piece(piece.Position.X -1, piece.Position.Y + 1)));
            }
            return moves;
        }

    }
}

