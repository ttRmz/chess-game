using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMIREZ_Tristan__Chess_Project_B2B_.Pieces
{
    class King : Piece
    {
        public King(Color c) : base(c, 'K')
        { 
        
        }
        public override List<Coord> GetUsuableCoordinates(Coord PieceCoord, Piece[,] Board)
        {
            List<Coord> Coords = new List<Coord>();
            Color adversaire = Color.White;
            if (color == Color.White)
            {
                adversaire = Color.Black;
            }
            //Le roi va en haut
            Piece PieceCaseAtk1 = Board[PieceCoord.x, PieceCoord.y + 1];
            if (PieceCaseAtk1 != null && PieceCaseAtk1.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x, PieceCoord.y + 1));
            if (PieceCaseAtk1 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x, PieceCoord.y + 1));
            //Le roi va à en haut droite
            Piece PieceCaseAtk2 = Board[PieceCoord.x + 1, PieceCoord.y + 1];
            if (PieceCaseAtk2 != null && PieceCaseAtk2.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x + 1, PieceCoord.y + 1));
            if (PieceCaseAtk2 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x + 1, PieceCoord.y + 1));
            //Le roi va à droite
            Piece PieceCaseAtk3 = Board[PieceCoord.x + 1, PieceCoord.y];
            if (PieceCaseAtk3 != null && PieceCaseAtk3.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x + 1, PieceCoord.y));
            if (PieceCaseAtk3 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x + 1, PieceCoord.y));
            //Le roi va en bas a droite
            Piece PieceCaseAtk4 = Board[PieceCoord.x + 1, PieceCoord.y - 1];
            if (PieceCaseAtk4 != null && PieceCaseAtk4.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x + 1, PieceCoord.y - 1));
            if (PieceCaseAtk4 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x + 1, PieceCoord.y - 1));
            //Le roi va en bas
            Piece PieceCaseAtk5 = Board[PieceCoord.x, PieceCoord.y - 1];
            if (PieceCaseAtk5 != null && PieceCaseAtk5.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x, PieceCoord.y - 1));
            if (PieceCaseAtk5 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x, PieceCoord.y - 1));
            //Le roi va en bas a gauche 
            Piece PieceCaseAtk6 = Board[PieceCoord.x - 1, PieceCoord.y - 1];
            if (PieceCaseAtk6 != null && PieceCaseAtk6.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x - 1, PieceCoord.y - 1));
            if (PieceCaseAtk6 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x - 1, PieceCoord.y - 1));
            //Le roi va a gauche 
            Piece PieceCaseAtk7 = Board[PieceCoord.x - 1, PieceCoord.y];
            if (PieceCaseAtk7 != null && PieceCaseAtk7.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x - 1, PieceCoord.y));
            if (PieceCaseAtk7 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x - 1, PieceCoord.y));
            //Le roi va a gauche
            Piece PieceCaseAtk8 = Board[PieceCoord.x - 1, PieceCoord.y + 1];
            if (PieceCaseAtk8 != null && PieceCaseAtk8.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
                Coords.Add(new Coord(PieceCoord.x - 1, PieceCoord.y + 1));
            if (PieceCaseAtk8 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
				Coords.Add(new Coord(PieceCoord.x - 1, PieceCoord.y + 1));
            return Coords;
        }
    }
}