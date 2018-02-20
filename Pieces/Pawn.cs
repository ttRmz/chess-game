using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMIREZ_Tristan__Chess_Project_B2B_.Pieces
{
    class Pawn : Piece
    {
        public Pawn(Color c) : base(c, 'P')
        {

        }
        public override List<Coord> GetUsuableCoordinates(Coord PieceCoord, Piece[,] Board)
        {
            List<Coord> Coords = new List<Coord>();
            int a = -1;
            Color adversaire = Color.White;
            if (color == Color.White)
            {
                adversaire = Color.Black;
                a = 1;
            }
            Piece PieceCaseMove = Board[PieceCoord.x, PieceCoord.y + a];
            if (PieceCaseMove == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x, PieceCoord.y + a));
            }
            //Le piont vas a droite
            Piece PieceCaseAtk1 = Board[PieceCoord.x + 1, PieceCoord.y + a];
            if (PieceCaseAtk1 != null && PieceCaseAtk1.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + 1, PieceCoord.y + a));
            }
            //Le piont va a gauche
            Piece PieceCaseAtk2 = Board[PieceCoord.x - 1, PieceCoord.y + a];
            if (PieceCaseAtk2 != null && PieceCaseAtk2.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x - 1, PieceCoord.y + a));
            }
            return Coords;
        }
    }
}
