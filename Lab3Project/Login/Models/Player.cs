using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public abstract class Player 
    {
        #region PublicProperties
        public  List<Piece> Pieces { get; set; }
        public string Username { get; set; }
        public Image Foto { get; set; }
        public int N_Games { get; set; } = 0;
        public int N_Wins { get; set; } = 0;
        public int N_Losts { get; set; } = 0;
        public int N_Left { get; set; } = 0;
        public bool IsTurn { get; set; }
        #endregion


        public Player()
        {
            Pieces = new List<Piece>();
            Foto = null;
            Username = "";
        }

        public void SetPiecesDefaultState()
        {
            if (Pieces.FirstOrDefault().Color == Color.White)
            {
                Pieces.Clear();
                Pieces.Add(new Piece(new Point(1, 5), Color.White));
                Pieces.Add(new Piece(new Point(3, 5), Color.White));
                Pieces.Add(new Piece(new Point(5, 5), Color.White));
                Pieces.Add(new Piece(new Point(7, 5), Color.White));
                Pieces.Add(new Piece(new Point(0, 6), Color.White));
                Pieces.Add(new Piece(new Point(2, 6), Color.White));
                Pieces.Add(new Piece(new Point(4, 6), Color.White));
                Pieces.Add(new Piece(new Point(6, 6), Color.White));
                Pieces.Add(new Piece(new Point(1, 7), Color.White));
                Pieces.Add(new Piece(new Point(3, 7), Color.White));
                Pieces.Add(new Piece(new Point(5, 7), Color.White));
                Pieces.Add(new Piece(new Point(7, 7), Color.White));
            }
            else
            {
                Pieces.Clear();
                Pieces.Add(new Piece(new Point(0, 0), Color.Blue));
                Pieces.Add(new Piece(new Point(2, 0), Color.Blue));
                Pieces.Add(new Piece(new Point(4, 0), Color.Blue));
                Pieces.Add(new Piece(new Point(6, 0), Color.Blue));
                Pieces.Add(new Piece(new Point(1, 1), Color.Blue));
                Pieces.Add(new Piece(new Point(3, 1), Color.Blue));
                Pieces.Add(new Piece(new Point(5, 1), Color.Blue));
                Pieces.Add(new Piece(new Point(7, 1), Color.Blue));
                Pieces.Add(new Piece(new Point(0, 2), Color.Blue));
                Pieces.Add(new Piece(new Point(2, 2), Color.Blue));
                Pieces.Add(new Piece(new Point(4, 2), Color.Blue));
                Pieces.Add(new Piece(new Point(6, 2), Color.Blue));
            }
        }
        public Player(string username, int n_games, int n_wins, int n_losts, int n_left)
        {
            Pieces = new List<Piece>();
            Foto = null;
            Username = username;
            IsTurn = false;
            N_Games = n_games;
            N_Wins = n_wins;
            N_Losts = n_losts;
            N_Left = n_left;
        }
   
        public void UpdatePiece(Point origin, Point destination)
        {
            if (IsTurn)
            {
                foreach ( Piece p in Pieces)
                {
                    if (p.Position==origin)
                    {
                        p.Position = destination;
                        break;
                    }
                }
            }
        }

        public Piece FindPiece(Point MatrixCoordinates)
        {
            foreach (Piece p in Pieces)
            {
                if (p.Position==MatrixCoordinates)
                {
                    return p;
                }
            }
            return new Piece(new Point(), new Color());
        }

        public bool CanBeEaten(Point origin, Point destination, ref int x, ref int y)
        {
            int[] XCoord = new[] { origin.X, destination.X };
            int[] YCoord = new[] { origin.Y, destination.Y };

            int highX = AuxFunctions.Highest(XCoord);
            int lowX = AuxFunctions.Lowest(XCoord);
            int highY = AuxFunctions.Highest(YCoord);
            int lowY = AuxFunctions.Lowest(YCoord);

            foreach (Piece piece in Pieces)
            {
                x = piece.Position.X;
                y = piece.Position.Y;
                
                if (AuxFunctions.IsBetween(lowX,highX, x) 
                    && AuxFunctions.IsBetween(lowY, highY, y))
                {
                    return true;
                }
            }
            return false;
        }

        

        
    }
}
