namespace TBO_Rubiks
{
    internal class Tuile
    {
        public string Couleur { get; set; }
        public ConsoleColor ConsoleCouleur { get; set; }
        public int LargeurTuile { get; set; }
        public int HauteurTuile { get; set; }
        public Tuile(string couleur, int largeurTuile, int hauteurTuile) {
            Couleur = couleur;
            ConsoleCouleur = GetColor(couleur);
            LargeurTuile = largeurTuile;
            HauteurTuile = hauteurTuile;
            
        }

        public ConsoleColor GetColor(string codeCouleur)
        {
            return codeCouleur switch
            {
                "W" => ConsoleColor.White,
                "Y" => ConsoleColor.Blue,
                "G" => ConsoleColor.Green,
                "R" => ConsoleColor.Red,
                "O" => ConsoleColor.DarkYellow,
                "B" => ConsoleColor.Magenta,
                _ => ConsoleColor.White
            };
        }

        public void Display(int x, int y)
        {
            Console.BackgroundColor = ConsoleCouleur;
            for (int i = 0; i < HauteurTuile; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(new string(' ', LargeurTuile));
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
