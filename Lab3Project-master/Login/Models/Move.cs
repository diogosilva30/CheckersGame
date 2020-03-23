
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabProject
{
    public class Move
    {
        #region PublicProperties
        public Piece origin { get; set; }
        public Piece destination { get; set; }
        #endregion

        public Move()
        {
            this.origin = null;
            this.destination = null;
        }

        public Move(Piece origin, Piece destination)
        {
            this.origin = origin;
            this.destination = destination;
        }

        public bool isAdjacent(string color)
        {
            if (color == "W")
            {
                if (origin.Position.X-1 == destination.Position.X && origin.Position.Y - 1 == destination.Position.Y)
                {
                    return true;
                }
                if (origin.Position.X + 1 == destination.Position.X && origin.Position.Y - 1 == destination.Position.Y)
                {
                    return true;
                }

            }
            if (color == "B")
            {
                if (origin.Position.X-1 == destination.Position.X && origin.Position.Y+1==destination.Position.Y)
                {
                    return true;
                }
                if (origin.Position.X + 1 == destination.Position.X && origin.Position.Y + 1 == destination.Position.Y)
                {
                    return true;
                }
            }
            if (color == "Q")
            {

                if (origin.Position.X-1 == destination.Position.X && origin.Position.Y-1==destination.Position.Y)
                {
                    return true;
                }
                if (origin.Position.X + 1 == destination.Position.X && origin.Position.Y - 1 == destination.Position.Y)
                {
                    return true;
                }
                if (origin.Position.X - 1 == destination.Position.X && origin.Position.Y + 1 == destination.Position.Y)
                {
                    return true;
                }
                if (origin.Position.X + 1 == destination.Position.X && origin.Position.Y + 1 == destination.Position.Y)
                {
                    return true;
                }
            }
            return false;
        }

        public Piece checkJump(string color)
        {
            if (color == "Black")
            {
                if ((origin.Position.X - 2 == destination.Position.X) && (origin.Position.Y - 2 == destination.Position.Y))
                    return new Piece(origin.Position.X - 1, origin.Position.Y - 1);
                if ((origin.Position.X - 2 == destination.Position.X) && (origin.Position.Y + 2 == destination.Position.Y))
                    return new Piece(origin.Position.X - 1, origin.Position.Y + 1);
            }
            if (color == "Red")
            {
                if ((origin.Position.X + 2 == destination.Position.X) && (origin.Position.Y - 2 == destination.Position.Y))
                    return new Piece(origin.Position.X + 1, origin.Position.Y - 1);
                if ((origin.Position.X + 2 == destination.Position.X) && (origin.Position.Y + 2 == destination.Position.Y))
                    return new Piece(origin.Position.X + 1, origin.Position.Y + 1);
            }
            if (color == "King")
            {
                if ((origin.Position.X - 2 == destination.Position.X) && (origin.Position.Y - 2 == destination.Position.Y))
                    return new Piece(origin.Position.X - 1, origin.Position.Y - 1);
                if ((origin.Position.X - 2 == destination.Position.X) && (origin.Position.Y + 2 == destination.Position.Y))
                    return new Piece(origin.Position.X - 1, origin.Position.Y + 1);
                if ((origin.Position.X + 2 == destination.Position.X) && (origin.Position.Y - 2 == destination.Position.Y))
                    return new Piece(origin.Position.X + 1, origin.Position.Y - 1);
                if ((origin.Position.X + 2 == destination.Position.X) && (origin.Position.Y + 2 == destination.Position.Y))
                    return new Piece(origin.Position.X + 1, origin.Position.Y + 1);
            }

            return null;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Move move = obj as Move;
            if ((System.Object)move == null)
            {
                return false;
            }

            return origin.Equals(move.origin) && destination.Equals(move.destination);
        }
    }
}