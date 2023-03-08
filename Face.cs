using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TBO_Rubiks
{
    internal class Face
    {
        public string[,] Couleurs { get; set; } = new string[3, 3];
        public int LargeurTuile { get; set; }
        public Face(string couleur = "W", int largeurTuile = 2)
        {
            LargeurTuile = largeurTuile;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Couleurs[i, j] = couleur;
                }
            }
            LargeurTuile = largeurTuile;
        }
        public void Display(int x, int y)
        {
            //Tuile 1
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = GetColor(Couleurs[0, 0]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 2
            Console.SetCursorPosition(x + LargeurTuile, y);
            Console.BackgroundColor = GetColor(Couleurs[0, 1]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 3
            Console.SetCursorPosition(x + (2 * LargeurTuile), y);
            Console.BackgroundColor = GetColor(Couleurs[0, 2]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 4
            Console.SetCursorPosition(x, y + 1);
            Console.BackgroundColor = GetColor(Couleurs[1, 0]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 5
            Console.SetCursorPosition(x + LargeurTuile, y + 1);
            Console.BackgroundColor = GetColor(Couleurs[1, 1]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 6
            Console.SetCursorPosition(x + (2 * LargeurTuile), y + 1);
            Console.BackgroundColor = GetColor(Couleurs[1, 2]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 7
            Console.SetCursorPosition(x, y + 2);
            Console.BackgroundColor = GetColor(Couleurs[2, 0]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 8
            Console.SetCursorPosition(x + LargeurTuile, y + 2);
            Console.BackgroundColor = GetColor(Couleurs[2, 1]);
            Console.WriteLine(new string(' ', LargeurTuile));
            //Tuile 9
            Console.SetCursorPosition(x + (2 * LargeurTuile), y + 2);
            Console.BackgroundColor = GetColor(Couleurs[2, 2]);
            Console.WriteLine(new string(' ', LargeurTuile));

          
        }
        public ConsoleColor GetColor(string codeCouleur)
        {
            return codeCouleur switch
            {
                "W" => ConsoleColor.White,
                "Y" => ConsoleColor.Yellow,
                "G" => ConsoleColor.Green,
                "R" => ConsoleColor.Red,
                "O" => ConsoleColor.DarkYellow,
                "B" => ConsoleColor.Blue,
                _ => ConsoleColor.White
            };
        }
    }
}
