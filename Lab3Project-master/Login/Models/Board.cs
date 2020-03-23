using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public class Board
    {
        #region PublicConsts
        public const int INVALID = -1;
        public const int EMPTY = 0;
        public const int WHITE_PIECE = 1;
        public const int BLUE_PIECE = 2;
        public const int BLUE_QUEEN = 22;
        public const int WHITE_QUEEN = 11;
        #endregion

        #region PublicProperties
        public int[,] BoardMatrix { get; set; }
        #endregion

        #region PublicEvents
        public event Methods1Point JumpMustBeTaken;
        public event Methods1Point EatPiece;
        #endregion


        public void DefaultState()
        {
            BoardMatrix[1, 0] = INVALID;
            BoardMatrix[3, 0] = INVALID;
            BoardMatrix[5, 0] = INVALID;
            BoardMatrix[7, 0] = INVALID;

            BoardMatrix[0, 1] = INVALID;
            BoardMatrix[2, 1] = INVALID;
            BoardMatrix[4, 1] = INVALID;
            BoardMatrix[6, 1] = INVALID;

            BoardMatrix[1, 2] = INVALID;
            BoardMatrix[3, 2] = INVALID;
            BoardMatrix[5, 2] = INVALID;
            BoardMatrix[7, 2] = INVALID;

            BoardMatrix[0, 3] = INVALID;
            BoardMatrix[2, 3] = INVALID;
            BoardMatrix[4, 3] = INVALID;
            BoardMatrix[6, 3] = INVALID;

            BoardMatrix[1, 4] = INVALID;
            BoardMatrix[3, 4] = INVALID;
            BoardMatrix[5, 4] = INVALID;
            BoardMatrix[7, 4] = INVALID;

            BoardMatrix[0, 5] = INVALID;
            BoardMatrix[2, 5] = INVALID;
            BoardMatrix[4, 5] = INVALID;
            BoardMatrix[6, 5] = INVALID;

            BoardMatrix[1, 6] = INVALID;
            BoardMatrix[3, 6] = INVALID;
            BoardMatrix[5, 6] = INVALID;
            BoardMatrix[7, 6] = INVALID;

            BoardMatrix[0, 7] = INVALID;
            BoardMatrix[2, 7] = INVALID;
            BoardMatrix[4, 7] = INVALID;
            BoardMatrix[6, 7] = INVALID;
        }
        public void SetDefaultState()
        {
            // SET ALL TO VALID
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    BoardMatrix[i, j] = EMPTY;
                }
            }

            DefaultState();

            BoardMatrix[1, 5] = WHITE_PIECE;
            BoardMatrix[3, 5] = WHITE_PIECE;
            BoardMatrix[5, 5] = WHITE_PIECE;
            BoardMatrix[7, 5] = WHITE_PIECE;

            BoardMatrix[0, 6] = WHITE_PIECE;
            BoardMatrix[2, 6] = WHITE_PIECE;
            BoardMatrix[4, 6] = WHITE_PIECE;
            BoardMatrix[6, 6] = WHITE_PIECE;

            BoardMatrix[1, 7] = WHITE_PIECE;
            BoardMatrix[3, 7] = WHITE_PIECE;
            BoardMatrix[5, 7] = WHITE_PIECE;
            BoardMatrix[7, 7] = WHITE_PIECE;


            BoardMatrix[0, 0] = BLUE_PIECE;
            BoardMatrix[2, 0] = BLUE_PIECE;
            BoardMatrix[4, 0] = BLUE_PIECE;
            BoardMatrix[6, 0] = BLUE_PIECE;

            BoardMatrix[1, 1] = BLUE_PIECE;
            BoardMatrix[3, 1] = BLUE_PIECE;
            BoardMatrix[5, 1] = BLUE_PIECE;
            BoardMatrix[7, 1] = BLUE_PIECE;

            BoardMatrix[0, 2] = BLUE_PIECE;
            BoardMatrix[2, 2] = BLUE_PIECE;
            BoardMatrix[4, 2] = BLUE_PIECE;
            BoardMatrix[6, 2] = BLUE_PIECE;
        }


        public Board()
        {

            BoardMatrix = new int[8, 8];
            SetDefaultState();
        }



       
        public bool CheckQueen(string colour, Point MatrixLocation)
        {
            if (colour == "W" && MatrixLocation.Y == 0)
            {
                BoardMatrix[MatrixLocation.X, MatrixLocation.Y] = WHITE_QUEEN;
                return true;
            }
            if (colour == "B" && MatrixLocation.Y == 7)
            {
                BoardMatrix[MatrixLocation.X, MatrixLocation.Y] = BLUE_QUEEN;
                return true;
            }
            return false;
        }

        public bool SetPosition(Point origin, Point destination, string colour)
        {
   
            if (colour=="B")
            {
                if (!CheckMoveBlue(origin, destination))
                    return false;
                
            }
            if (colour=="W")
            {
                if (!CheckMoveWhite(origin, destination))
                {
                    return false;
                }
            }
            
            if (colour == "W" && BoardMatrix[origin.X, origin.Y]==WHITE_QUEEN)
            {
                BoardMatrix[destination.X, destination.Y] = WHITE_QUEEN;
            }
            else if (colour == "B" && BoardMatrix[origin.X, origin.Y]==BLUE_QUEEN)
            {
                BoardMatrix[destination.X, destination.Y] = BLUE_QUEEN;
            }
            else if (colour == "W")
            {
                BoardMatrix[destination.X, destination.Y] = WHITE_PIECE;
            }
            else if (colour == "B")
            {
                BoardMatrix[destination.X, destination.Y] = BLUE_PIECE;
            }
            BoardMatrix[origin.X, origin.Y] = EMPTY;
            return true;

        }
       
        public List<Move> CheckJumps(string color)
        {
            List<Move> jumps = new List<Move>();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (color == "B")
                    {
                        if (GetState(i, j) == BLUE_QUEEN)
                        {
                            if ((GetState(i - 2, j - 2) == EMPTY) && ((GetState(i - 1, j - 1) == WHITE_PIECE) || (GetState(i - 1, j - 1) == WHITE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i - 2, j - 2)));
                            }
                            if ((GetState(i - 2, j + 2) == EMPTY) && ((GetState(i - 1, j + 1) == WHITE_PIECE) || (GetState(i - 1, j + 1) == WHITE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i , j), new Piece(i - 2, j + 2)));
                            }
                            if ((GetState(i + 2, j - 2) == EMPTY) && ((GetState(i + 1, j - 1) == WHITE_PIECE) || (GetState(i + 1, j - 1) == WHITE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i , j), new Piece(i + 2, j - 2)));
                            }
                            if ((GetState(i + 2, j + 2) == EMPTY) && ((GetState(i + 1, j + 1) == WHITE_PIECE) || (GetState(i + 1, j + 1) == WHITE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i , j), new Piece(i + 2, j + 2)));
                            }
                        }
                        if (GetState(i, j) == BLUE_PIECE)
                        {
                            if ((GetState(i + 2, j + 2) == EMPTY) && ((GetState(i + 1, j + 1) == WHITE_PIECE) || (GetState(i + 1, j + 1) == WHITE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i + 2, j + 2)));
                            }
                            if ((GetState(i - 2, j + 2) == EMPTY) && ((GetState(i - 1, j + 1) == WHITE_PIECE) || (GetState(i - 1, j + 1) == WHITE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i -2, j + 2)));
                            }
                        }
                    }
                    if (color == "W")
                    {
                        if (GetState(i, j) == WHITE_QUEEN)
                        {
                            if ((GetState(i - 2, j - 2) == EMPTY) && ((GetState(i - 1, j - 1) == BLUE_PIECE) || (GetState(i - 1, j - 1) == BLUE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i - 2, j - 2)));
                            }
                            if ((GetState(i - 2, j + 2) == EMPTY) && ((GetState(i - 1, j + 1) == BLUE_PIECE) || (GetState(i - 1, j + 1) == BLUE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i - 2, j + 2)));
                            }
                            if ((GetState(i + 2, j - 2) == EMPTY) && ((GetState(i + 1, j - 1) == BLUE_PIECE) || (GetState(i + 1, j - 1) == BLUE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i + 2, j - 2)));
                            }
                            if ((GetState(i + 2, j + 2) == EMPTY) && ((GetState(i + 1, j + 1) == BLUE_PIECE) || (GetState(i + 1, j + 1) == BLUE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i +2, j + 2)));
                            }
                        }
                        if (GetState(i, j) == WHITE_PIECE)
                        {
                            if ((GetState(i - 2, j - 2) == EMPTY) && ((GetState(i - 1, j - 1) == BLUE_PIECE) || (GetState(i - 1, j - 1) == BLUE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i, j), new Piece(i - 2, j - 2)));
                            }
                            if ((GetState(i + 2, j - 2) == EMPTY) && ((GetState(i + 1, j - 1) == BLUE_PIECE) || (GetState(i + 1, j - 1) == BLUE_QUEEN)))
                            {
                                jumps.Add(new Move(new Piece(i , j), new Piece(i +2, j - 2)));
                            }
                        }
                    }
                }
            }

            return jumps;
        }

        public int GetState(int r, int c)
        {
            if ((r > 7) || (r < 0) || (c > 7) || (c < 0))
                return -1;
            return BoardMatrix[r, c];
        }

        

        private bool CheckMoveWhite(Point origin, Point destination)
        {
            int[] xValues = { origin.X, destination.X };
            int[] yValues = { origin.Y, destination.Y };
            Move currentMove = new Move(new Piece(origin), new Piece(destination));

            List<Move> jumpMoves = CheckJumps("W");

            if (jumpMoves.Count > 0)
            {
                bool invalid = true;
                foreach (Move move in jumpMoves)
                {
                    if (currentMove.Equals(move))
                        invalid = false;
                }
                if (invalid)
                {
                    JumpMustBeTaken?.Invoke(jumpMoves[0].destination.Position);
                    currentMove.origin = null;
                    currentMove.destination = null;
                    return false;
                }
                
                EatPiece?.Invoke(new Point(AuxFunctions.Highest(xValues) - 1, AuxFunctions.Highest(yValues) -1));
                
                return true;
            }

            if (Program.M_Game.Game.FindPiece(origin).Color == Color.White)
            {
                if (Program.M_Game.Game.FindPiece(origin).IsQueen)
                {
                    if (currentMove.isAdjacent("Q") && BoardMatrix[destination.X, destination.Y] == EMPTY)
                    {
                        return true;
                    }
                    Piece middlePiece = currentMove.checkJump("Q");
                    if (middlePiece != null && BoardMatrix[destination.X, destination.Y] == EMPTY)
                    {
                        EatPiece?.Invoke(new Point(AuxFunctions.Highest(xValues) - 1, AuxFunctions.Highest(yValues) - 1));
                        return true;
                    }
                }
                else
                {
                    if ((currentMove.isAdjacent("W")) && BoardMatrix[destination.X, destination.Y] == EMPTY)
                        return true;

                    Piece midPiece = currentMove.checkJump("W");

                    if (midPiece != null && BoardMatrix[destination.X, destination.Y] == EMPTY)
                    {
                        EatPiece?.Invoke(new Point(AuxFunctions.Highest(xValues) - 1, AuxFunctions.Highest(yValues) - 1));
                        return true;
                    }

                }
            }
            return false;
        }
    
        public bool CheckMoveBlue(Point origin, Point destination)
        {
            Move currentMove = new Move(new Piece(origin), new Piece(destination));
            int[] xValues = { origin.X, destination.X };
            int[] yValues = { origin.Y, destination.Y };
            List<Move> jumpMoves = CheckJumps("B");

            if (jumpMoves.Count > 0)
            {
                bool invalid = true;
                foreach (Move move in jumpMoves)
                {
                    if (currentMove.Equals(move))
                        invalid = false;
                }
                if (invalid)
                {
                    JumpMustBeTaken?.Invoke(jumpMoves[0].destination.Position);
                    return false;
                }
               
                EatPiece?.Invoke(new Point(AuxFunctions.Highest(xValues) - 1, AuxFunctions.Highest(yValues) -1));

                return true;
            }

            if (Program.M_Game.Game.FindPiece(origin).Color == Color.Blue)
            {
                if (Program.M_Game.Game.FindPiece(origin).IsQueen)
                {
                    if (currentMove.isAdjacent("Q") && BoardMatrix[destination.X, destination.Y] == EMPTY)
                    {
                        return true;
                    }
                    Piece middlePiece = currentMove.checkJump("Q");
                    if (middlePiece != null && BoardMatrix[destination.X, destination.Y] == EMPTY)
                    {
                        EatPiece?.Invoke(new Point(AuxFunctions.Highest(xValues) -1, AuxFunctions.Highest(yValues) - 1));
                        return true;
                    }
                }
                else
                {
                    if ((currentMove.isAdjacent("B")) && BoardMatrix[destination.X, destination.Y] == EMPTY)
                        return true;

                    Piece midPiece = currentMove.checkJump("B");

                    if (midPiece != null && BoardMatrix[destination.X, destination.Y] == EMPTY)
                    {
                        EatPiece?.Invoke(new Point(AuxFunctions.Highest(xValues) - 1, AuxFunctions.Highest(yValues) - 1));
                        return true;
                    }

                }
            }
            return false;
        }

        


    }
}
