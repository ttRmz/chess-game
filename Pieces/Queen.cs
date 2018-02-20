using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMIREZ_Tristan__Chess_Project_B2B_.Pieces
{
    class Queen : Piece
    {
    public Queen(Color c) : base(c, 'Q')
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
            //La reine vas en haut a droite
            Piece PieceCaseAtkLikeFool1 = Board[PieceCoord.x + a, PieceCoord.y + a];
            while (PieceCaseAtkLikeFool1 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y + a));
                a++;
            }
            if (PieceCaseAtkLikeFool1 != null && PieceCaseAtkLikeFool1.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y + a));
                a = 1;
                //reset a à 1
            }
            else a = 1;
            //La reine va en haut a gauche
            Piece PieceCaseAtkLikeFool2 = Board[PieceCoord.x - a , PieceCoord.y + a];
            while (PieceCaseAtkLikeFool2 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y + a));
                a++;
            }
            if (PieceCaseAtkLikeFool2 != null && PieceCaseAtkLikeFool2.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y + a));
                a = 1;
                //reset a à 1
            }
            else a = 1;
			//La reine va en bas a droite
			Piece PieceCaseAtkLikeFool3 = Board[PieceCoord.x + a, PieceCoord.y - a];
			while (PieceCaseAtkLikeFool3 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y - a));
				a++;
			}
			if (PieceCaseAtkLikeFool3 != null && PieceCaseAtkLikeFool3.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y - a));
				a = 1;
				//reset a à 1
			}
            else a = 1;
            //La reine va en bas a gauche
			Piece PieceCaseAtkLikeFool4 = Board[PieceCoord.x - a, PieceCoord.y - a];
            while (PieceCaseAtkLikeFool4 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y - a));
				a++;
			}
			if (PieceCaseAtkLikeFool4 != null && PieceCaseAtkLikeFool4.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y - a));
				a = 1;
				//reset a à 1
			}
            else a = 1;//La reine vas en haut
            Piece PieceCaseAtkLikeTower1 = Board[PieceCoord.x , PieceCoord.y + a];
            while (PieceCaseAtkLikeTower1 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x , PieceCoord.y + a));
                a++;
            }
            if (PieceCaseAtkLikeTower1 != null && PieceCaseAtkLikeTower1.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x , PieceCoord.y + a));
                a = 1;
                //reset a à 1
            }
            else a = 1;
            //La reine vas a droite
            Piece PieceCaseAtkLikeTower2 = Board[PieceCoord.x + a , PieceCoord.y];
            while (PieceCaseAtkLikeTower2 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + a , PieceCoord.y));
                a++;
            }
            if (PieceCaseAtkLikeTower2 != null && PieceCaseAtkLikeTower2.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + a , PieceCoord.y));
                a = 1;
                //reset a à 1
            }
            else a = 1;
            //La reine vas en bas
            Piece PieceCaseAtkLikeTower3 = Board[PieceCoord.x, PieceCoord.y - a];
            while (PieceCaseAtkLikeTower3 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x, PieceCoord.y - a));
                a++;
            }
            if (PieceCaseAtkLikeTower3 != null && PieceCaseAtkLikeTower3.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x, PieceCoord.y - a));
                a = 1;
                //reset a à 1
            }
            else a = 1;
            //La reine vas à gauche
            Piece PieceCaseAtkLikeTower4 = Board[PieceCoord.x - a, PieceCoord.y];
            while (PieceCaseAtkLikeTower4 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y));
                a++;
            }
            if (PieceCaseAtkLikeTower4 != null && PieceCaseAtkLikeTower4.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y));
                a = 1;
                //reset a à 1
            }
            else a = 1;
            return Coords;
        }
    }
}