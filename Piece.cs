using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMIREZ_Tristan__Chess_Project_B2B_
{
    class Piece
    {
        public enum Color { White, Black }
        public Color color;
        public char PieceName;
        public Piece(Color c,char pn)
        {
            color = c;
            PieceName = pn;
        }
  
        public virtual List<Coord> GetUsuableCoordinates(Coord PieceCoord, Piece[,] Board)
        {
            return new List<Coord>();
        }
    }
}
