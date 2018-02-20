using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMIREZ_Tristan__Chess_Project_B2B_
{
    class Game
    {
        public Player p1, p2;
        public Piece[,] Cases;
        public int NbTurns;

        public Game ()
        {
            //Initialisation du plateau de jeu
            Cases = new Piece[8, 8];
            //Placement des tours
            Cases[0, 0] = new Pieces.Tower(Piece.Color.Black);
            Cases[7, 0] = new Pieces.Tower(Piece.Color.Black);
            Cases[0, 7] = new Pieces.Tower(Piece.Color.White);
            Cases[7, 7] = new Pieces.Tower(Piece.Color.White);
            //Placement des chevaliers
            Cases[1, 0] = new Pieces.Horseman(Piece.Color.Black);
            Cases[6, 0] = new Pieces.Horseman(Piece.Color.Black);
            Cases[1, 7] = new Pieces.Horseman(Piece.Color.White);
            Cases[6, 7] = new Pieces.Horseman(Piece.Color.White);
            //Placement des fous
            Cases[2, 0] = new Pieces.Fool(Piece.Color.Black);
            Cases[5, 0] = new Pieces.Fool(Piece.Color.Black);
            Cases[2, 7] = new Pieces.Fool(Piece.Color.White);
            Cases[5, 7] = new Pieces.Fool(Piece.Color.White);
            //Placement des rois
            Cases[3, 0] = new Pieces.King(Piece.Color.Black);
            Cases[3, 7] = new Pieces.King(Piece.Color.White);
            //Placement des dames
            Cases[4, 0] = new Pieces.Queen(Piece.Color.Black);
            Cases[4, 7] = new Pieces.Queen(Piece.Color.White);
            //Placement de pionts noirs
            Cases[0, 1] = new Pieces.Pawn(Piece.Color.Black);
            Cases[1, 1] = new Pieces.Pawn(Piece.Color.Black);
            Cases[2, 1] = new Pieces.Pawn(Piece.Color.Black);
            Cases[3, 1] = new Pieces.Pawn(Piece.Color.Black);
            Cases[4, 1] = new Pieces.Pawn(Piece.Color.Black);
            Cases[5, 1] = new Pieces.Pawn(Piece.Color.Black);
            Cases[6, 1] = new Pieces.Pawn(Piece.Color.Black);
            Cases[7, 1] = new Pieces.Pawn(Piece.Color.Black);
            //Placement de pionts blancs
            Cases[0, 6] = new Pieces.Pawn(Piece.Color.White);
            Cases[1, 6] = new Pieces.Pawn(Piece.Color.White);
            Cases[2, 6] = new Pieces.Pawn(Piece.Color.White);
            Cases[3, 6] = new Pieces.Pawn(Piece.Color.White);
            Cases[4, 6] = new Pieces.Pawn(Piece.Color.White);
            Cases[5, 6] = new Pieces.Pawn(Piece.Color.White);
            Cases[6, 6] = new Pieces.Pawn(Piece.Color.White);
            Cases[7, 6] = new Pieces.Pawn(Piece.Color.White);
        }

        public void StartGame ()
        {
            p1 = new Player();
            p2 = new Player();
            if (NbTurns % 2 == 1)
                p1.IsMyTurn = true;
            else
                p2.IsMyTurn = true;
            p1.color = Piece.Color.White;
            p2.color = Piece.Color.Black;
            Console.WriteLine("Tunrn" + NbTurns);
        }

        public void GameTurn()
        {
            NbTurns = 1;
            StartGame();
            PrintGameboard();
            Coord xy = AskForACoord();
            Piece p = Cases[xy.x, xy.y];

            while (p == null || NbTurns % 2 == 1 && p.color == Piece.Color.Black || NbTurns % 2 == 0 && p.color == Piece.Color.White)
            {
                Console.WriteLine("Unavailable move !");
                xy = AskForACoord();
                p = Cases[xy.x, xy.y];
            }
            Console.WriteLine("Where do you want to go ?");
            Coord xybis = AskForACoord();
            Piece pbis = Cases[xy.x, xy.y];

            //TODO Verifier si la case est dans les coords données
            //TODO Bouger la piece

            IsGameOver();
            NbTurns++;
            
        }

        public Coord AskForACoord()
        {
            Console.WriteLine("Abscisse ?");
            int abs = Convert.ToInt32(Console.ReadLine());
            while(abs < 0 || abs > 7)
            {
                Console.WriteLine("Retry");
                abs = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ordonnée ?");
            int ord = Convert.ToInt32(Console.ReadLine());
            while(ord < 0 || ord > 7)
            {
                Console.WriteLine("Retry");
                ord = Convert.ToInt32(Console.ReadLine());
            }
            return new Coord(abs, ord);
        }
        public bool IsGameOver()
        {
            //TODO Tester la fin de la partie
            return false;
        }
        public void PrintGameboard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Cases[j, i] == null)
                        Console.Write(" | () | ");
                    else if (Cases[j, i].color == Piece.Color.Black)
                        Console.Write(" | " + Cases[j, i].PieceName + "B | ");
                    else if (Cases[j, i].color == Piece.Color.White)
                        Console.Write(" | " + Cases[j, i].PieceName + "W | ");
                }
                Console.WriteLine();
            }
        }
    }
}
