﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMIREZ_Tristan__Chess_Project_B2B_.Pieces
{
    class Fool : Piece
    {
        public Fool(Color c) : base(c, 'F')
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
            //Le fou vas en haut a droite
            Piece PieceCaseAtk1 = Board[PieceCoord.x + a, PieceCoord.y + a];
            while (PieceCaseAtk1 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y + a));
                a++;
            }
            if (PieceCaseAtk1 != null && PieceCaseAtk1.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y + a));
                a = 1;
                //reset a à 1
            }
            else a = 1;
            //Le fou va en haut a gauche
            Piece PieceCaseAtk2 = Board[PieceCoord.x - a , PieceCoord.y + a];
            while (PieceCaseAtk2 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y + a));
                a++;
            }
            if (PieceCaseAtk2 != null && PieceCaseAtk2.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
            {
                Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y + a));
                a = 1;
                //reset a à 1
            }
            else a = 1;
			//Le fou va en bas a droite
			Piece PieceCaseAtk3 = Board[PieceCoord.x + a, PieceCoord.y - a];
			while (PieceCaseAtk3 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y - a));
				a++;
			}
			if (PieceCaseAtk3 != null && PieceCaseAtk3.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x + a, PieceCoord.y - a));
				a = 1;
				//reset a à 1
			}
            else a = 1;
            //Le fou va en bas a gauche
			Piece PieceCaseAtk4 = Board[PieceCoord.x - a, PieceCoord.y - a];
            while (PieceCaseAtk4 == null && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y - a));
				a++;
			}
			if (PieceCaseAtk4 != null && PieceCaseAtk4.color == adversaire && PieceCoord.x < 8 && PieceCoord.y < 8 && PieceCoord.x >= 0 && PieceCoord.y >= 0)
			{
				Coords.Add(new Coord(PieceCoord.x - a, PieceCoord.y - a));
				a = 1;
				//reset a à 1
			}
            else a = 1;
            return Coords;
        }
    }
}
