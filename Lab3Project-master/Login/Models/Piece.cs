using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public class Piece
    {
        #region PublicProperties
        public bool IsQueen { get; set; }
        public Point Position { get; set; }
        public Color Color { get; set; }
        #endregion

        public Piece(Point point, Color color)
        {
            Position = point;
            Color = color;
            IsQueen = false;

        }
        public Piece(Point point)
        {
            Position = point;
        }
        public Piece(int i, int j)
        {
            Position = new Point(i, j);
        }
        public Piece()
        {

        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Piece piece = obj as Piece;
            if ((System.Object)piece == null)
            {
                return false;
            }

            return Position.X == piece.Position.X && Position.Y == piece.Position.Y;
        }
    }
}
