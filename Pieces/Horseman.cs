using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMIREZ_Tristan__Chess_Project_B2B_.Pieces
{
    class Horseman : Piece
    {

        public Horseman(Color c) : base(c, 'H')
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
            int a = 1;
            int b = 2;
            //Le chevalier vas en haut a droite
            Piece PieceCaseAtk1 = Board[PieceCoord.x + a, PieceCoord.y + b];
            if (PieceCaseAtk1 != null && PieceCaseAtk1.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y + b));
            }
            if (PieceCaseAtk1 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
                Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y + b));
			}
            //Le chevalier va en haut a gauche
			Piece PieceCaseAtk2 = Board[PieceCoord.x - a , PieceCoord.y + b];
			if (PieceCaseAtk2 != null && PieceCaseAtk2.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y + b));
			}
			if (PieceCaseAtk2 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y + b));
			}
			//Le chevalier va a gauche en haut
            Piece PieceCaseAtk3 = Board[PieceCoord.x - b, PieceCoord.y + a];
            if (PieceCaseAtk3 != null && PieceCaseAtk3.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - b, PieceCoord.y + a));
			}
            if (PieceCaseAtk3 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - b, PieceCoord.y + a));
			}
            //Le chevalier va a gauche en bas
            Piece PieceCaseAtk4 = Board[PieceCoord.x - b, PieceCoord.y - a];
            if (PieceCaseAtk4 != null && PieceCaseAtk4.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - b, PieceCoord.y - a));
			}
            if (PieceCaseAtk4 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - b, PieceCoord.y - a));
			}
            //Le chevalier va en bas a gauche
            Piece PieceCaseAtk5 = Board[PieceCoord.x - a, PieceCoord.y - b];
            if (PieceCaseAtk5 != null && PieceCaseAtk5.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y - b));
			}
            if (PieceCaseAtk5 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y - b));
			}
            //Le chevalier va en bas a droite
            Piece PieceCaseAtk6 = Board[PieceCoord.x + a, PieceCoord.y - b];
            if (PieceCaseAtk6 != null && PieceCaseAtk6.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y - b));
			}
            if (PieceCaseAtk6 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y - b));
			}
            //Le chevalier va a droite en bas
            Piece PieceCaseAtk7 = Board[PieceCoord.x + b, PieceCoord.y - a];
            if (PieceCaseAtk7 != null && PieceCaseAtk7.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + b, PieceCoord.y - a));
			}
            if (PieceCaseAtk7 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + b, PieceCoord.y - a));
			}
            //Le chevalier va a droite en haut
            Piece PieceCaseAtk8 = Board[PieceCoord.x + b, PieceCoord.y + a];
            if (PieceCaseAtk8 != null && PieceCaseAtk8.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + b, PieceCoord.y + a));
			}
            if (PieceCaseAtk8 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + b, PieceCoord.y + a));
			}
			return Coords;
        }
    }
}
