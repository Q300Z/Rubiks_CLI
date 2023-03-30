namespace TBO_Rubiks
{
    internal class Face
    {
        public Tuile[,] Tuiles { get; set; }
        public int LargeurTuile { get; set; }
        public int HauteurTuile { get; set; }
        public Face(string couleur = "W", int largeurTuile = 2, int hauteurTuile = 2)
        {
            Tuiles = new Tuile[3, 3];
            LargeurTuile = largeurTuile;
            HauteurTuile = hauteurTuile;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Tuiles[i, j] = new Tuile(couleur, largeurTuile, hauteurTuile, $" {i},{j}  ");
                    Tuiles[i, j] = new Tuile(couleur, largeurTuile, hauteurTuile);
                }
            }
            LargeurTuile = largeurTuile;
        }

        public void Display(int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Tuiles[i, j].Display(x + (i * LargeurTuile), y + (j * HauteurTuile));
                }
            }
        }
    }
}
