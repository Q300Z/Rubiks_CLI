namespace TBO_Rubiks
{
    internal class Cube
    {
        public int LargeurTuile { get; set; }
        public int HauteurTuile { get; set; }
        public Face Top { get; set; } = new Face("W");
        public Face Bottom { get; set; } = new Face("Y");
        public Face Front { get; set; } = new Face("R");
        public Face Back { get; set; } = new Face("O");
        public Face Left { get; set; } = new Face("G");
        public Face Right { get; set; } = new Face("B");

        public Cube(int largeurTuile, int hauteurTuile)
        {
            LargeurTuile = largeurTuile;
            HauteurTuile = hauteurTuile;
            Top = new Face("W", LargeurTuile, HauteurTuile);
            Bottom = new Face("Y", LargeurTuile, HauteurTuile);
            Front = new Face("R", LargeurTuile, HauteurTuile);
            Back = new Face("O", LargeurTuile, HauteurTuile);
            Left = new Face("G", LargeurTuile, HauteurTuile);
            Right = new Face("B", LargeurTuile, HauteurTuile);


        }
        public void Display()
        {
            Top.Display(3 * LargeurTuile, 1);
            Left.Display(0, 1 + (3 * HauteurTuile));
            Front.Display(3 * LargeurTuile, 1 + (3 * HauteurTuile));
            Right.Display(3 * 2 * LargeurTuile, 1 + (3 * HauteurTuile));
            Back.Display(3 * 3 * LargeurTuile, 1 + (3 * HauteurTuile));
            Bottom.Display(3 * LargeurTuile, 1 + (2 * 3 * HauteurTuile));
        }

        public void reset()
        {
            Top = new Face("W", LargeurTuile, HauteurTuile);
            Bottom = new Face("Y", LargeurTuile, HauteurTuile);
            Front = new Face("R", LargeurTuile, HauteurTuile);
            Back = new Face("O", LargeurTuile, HauteurTuile);
            Left = new Face("G", LargeurTuile, HauteurTuile);
            Right = new Face("B", LargeurTuile, HauteurTuile);
        }

        public void F()
        {
            //arrete
            var temp = Front.Tuiles[0, 0];
            Front.Tuiles[0, 0] = Front.Tuiles[0, 2];
            Front.Tuiles[0, 2] = Front.Tuiles[2, 2];
            Front.Tuiles[2, 2] = Front.Tuiles[2, 0];
            Front.Tuiles[2, 0] = temp;

            //coin
            temp = Front.Tuiles[1, 0];
            Front.Tuiles[1, 0] = Front.Tuiles[0, 1];
            Front.Tuiles[0, 1] = Front.Tuiles[1, 2];
            Front.Tuiles[1, 2] = Front.Tuiles[2, 1];
            Front.Tuiles[2, 1] = temp;

            var Right1 = Right.Tuiles[0, 0];
            var Right2 = Right.Tuiles[0, 1];
            var Right3 = Right.Tuiles[0, 2];

            Right.Tuiles[0, 0] = Top.Tuiles[0, 2];
            Right.Tuiles[0, 1] = Top.Tuiles[1, 2];
            Right.Tuiles[0, 2] = Top.Tuiles[2, 2];

            Top.Tuiles[0, 2] = Left.Tuiles[2, 2];
            Top.Tuiles[1, 2] = Left.Tuiles[2, 1];
            Top.Tuiles[2, 2] = Left.Tuiles[2, 0];

            Left.Tuiles[2, 2] = Bottom.Tuiles[2, 0];
            Left.Tuiles[2, 1] = Bottom.Tuiles[1, 0];
            Left.Tuiles[2, 0] = Bottom.Tuiles[0, 0];

            Bottom.Tuiles[2, 0] = Right1;
            Bottom.Tuiles[1, 0] = Right2;
            Bottom.Tuiles[0, 0] = Right3;
        }

        public void FP()
        {
            F();
            F();
            F();
        }

        public void B()
        {
            //arrete
            var temp = Back.Tuiles[0, 0];
            Back.Tuiles[0, 0] = Back.Tuiles[0, 2];
            Back.Tuiles[0, 2] = Back.Tuiles[2, 2];
            Back.Tuiles[2, 2] = Back.Tuiles[2, 0];
            Back.Tuiles[2, 0] = temp;

            //coin
            temp = Back.Tuiles[1, 0];
            Back.Tuiles[1, 0] = Back.Tuiles[0, 1];
            Back.Tuiles[0, 1] = Back.Tuiles[1, 2];
            Back.Tuiles[1, 2] = Back.Tuiles[2, 1];
            Back.Tuiles[2, 1] = temp;


            var Right1 = Right.Tuiles[2, 0];
            var Right2 = Right.Tuiles[2, 1];
            var Right3 = Right.Tuiles[2, 2];


            Right.Tuiles[2, 0] = Bottom.Tuiles[2, 2];
            Right.Tuiles[2, 1] = Bottom.Tuiles[1, 2];
            Right.Tuiles[2, 2] = Bottom.Tuiles[0, 2];

            Bottom.Tuiles[2, 2] = Left.Tuiles[0, 2];
            Bottom.Tuiles[1, 2] = Left.Tuiles[0, 1];
            Bottom.Tuiles[0, 2] = Left.Tuiles[0, 0];

            Left.Tuiles[0, 2] = Top.Tuiles[0, 0];
            Left.Tuiles[0, 1] = Top.Tuiles[1, 0];
            Left.Tuiles[0, 0] = Top.Tuiles[2, 0];

            Top.Tuiles[0, 0] = Right1;
            Top.Tuiles[1, 0] = Right2;
            Top.Tuiles[2, 0] = Right3;
        }
        public void BP()
        {
            B();
            B();
            B();
        }

        public void UL()
        {
            UR();
            UR();
            UR();
        }
        public void UR()
        {
            var temp = new Tuile[3];
            for (int i = 0; i < 3; i++)
            {
                temp[i] = Front.Tuiles[i, 0];
                Front.Tuiles[i, 0] = Left.Tuiles[i, 0];
                Left.Tuiles[i, 0] = Back.Tuiles[i, 0];
                Back.Tuiles[i, 0] = Right.Tuiles[i, 0];
                Right.Tuiles[i, 0] = temp[i];
            }
            //arrete
            var temp1 = Top.Tuiles[0, 0];
            Top.Tuiles[0, 0] = Top.Tuiles[2, 0];
            Top.Tuiles[2, 0] = Top.Tuiles[2, 2];
            Top.Tuiles[2, 2] = Top.Tuiles[0, 2];
            Top.Tuiles[0, 2] = temp1;

            //coin
            temp1 = Top.Tuiles[1, 0];
            Top.Tuiles[1, 0] = Top.Tuiles[2, 1];
            Top.Tuiles[2, 1] = Top.Tuiles[1, 2];
            Top.Tuiles[1, 2] = Top.Tuiles[0, 1];
            Top.Tuiles[0, 1] = temp1;
        }
        public void DL()
        {
            var temp = new Tuile[3];
            for (int i = 0; i < 3; i++)
            {
                temp[i] = Front.Tuiles[i, 2];
                Front.Tuiles[i, 2] = Left.Tuiles[i, 2];
                Left.Tuiles[i, 2] = Back.Tuiles[i, 2];
                Back.Tuiles[i, 2] = Right.Tuiles[i, 2];
                Right.Tuiles[i, 2] = temp[i];
            }

            //arrete
            var temp1 = Bottom.Tuiles[0, 0];
            Bottom.Tuiles[0, 0] = Bottom.Tuiles[0, 2];
            Bottom.Tuiles[0, 2] = Bottom.Tuiles[2, 2];
            Bottom.Tuiles[2, 2] = Bottom.Tuiles[2, 0];
            Bottom.Tuiles[2, 0] = temp1;

            //coin
            temp1 = Bottom.Tuiles[1, 0];
            Bottom.Tuiles[1, 0] = Bottom.Tuiles[0, 1];
            Bottom.Tuiles[0, 1] = Bottom.Tuiles[1, 2];
            Bottom.Tuiles[1, 2] = Bottom.Tuiles[2, 1];
            Bottom.Tuiles[2, 1] = temp1;
        }
        public void DR()
        {
            DL();
            DL();
            DL();
        }
        public void LL()
        {
            LR();
            LR();
            LR();
        }
        public void LR()
        {
            var front0 = Front.Tuiles[0, 0];
            var front1 = Front.Tuiles[0, 1];
            var front2 = Front.Tuiles[0, 2];

            Front.Tuiles[0, 0] = Bottom.Tuiles[0, 0];
            Front.Tuiles[0, 1] = Bottom.Tuiles[0, 1];
            Front.Tuiles[0, 2] = Bottom.Tuiles[0, 2];

            Bottom.Tuiles[0, 0] = Back.Tuiles[2, 0];
            Bottom.Tuiles[0, 1] = Back.Tuiles[2, 1];
            Bottom.Tuiles[0, 2] = Back.Tuiles[2, 2];

            Back.Tuiles[2, 0] = Top.Tuiles[0, 0];
            Back.Tuiles[2, 1] = Top.Tuiles[0, 1];
            Back.Tuiles[2, 2] = Top.Tuiles[0, 2];

            Top.Tuiles[0, 0] = front0;
            Top.Tuiles[0, 1] = front1;
            Top.Tuiles[0, 2] = front2;

            //Rotation Gauche
            //arrete
            var temp = Left.Tuiles[0, 0];
            Left.Tuiles[0, 0] = Left.Tuiles[2, 0];
            Left.Tuiles[2, 0] = Left.Tuiles[2, 2];
            Left.Tuiles[2, 2] = Left.Tuiles[0, 2];
            Left.Tuiles[0, 2] = temp;

            //coin
            temp = Left.Tuiles[1, 0];
            Left.Tuiles[1, 0] = Left.Tuiles[2, 1];
            Left.Tuiles[2, 1] = Left.Tuiles[1, 2];
            Left.Tuiles[1, 2] = Left.Tuiles[0, 1];
            Left.Tuiles[0, 1] = temp;
        }
        public void RL()
        {
            var front0 = Front.Tuiles[2, 0];
            var front1 = Front.Tuiles[2, 1];
            var front2 = Front.Tuiles[2, 2];

            Front.Tuiles[2, 0] = Bottom.Tuiles[2, 0];
            Front.Tuiles[2, 1] = Bottom.Tuiles[2, 1];
            Front.Tuiles[2, 2] = Bottom.Tuiles[2, 2];

            Bottom.Tuiles[2, 0] = Back.Tuiles[0, 0];
            Bottom.Tuiles[2, 1] = Back.Tuiles[0, 1];
            Bottom.Tuiles[2, 2] = Back.Tuiles[0, 2];

            Back.Tuiles[0, 0] = Top.Tuiles[2, 0];
            Back.Tuiles[0, 1] = Top.Tuiles[2, 1];
            Back.Tuiles[0, 2] = Top.Tuiles[2, 2];

            Top.Tuiles[2, 0] = front0;
            Top.Tuiles[2, 1] = front1;
            Top.Tuiles[2, 2] = front2;

            //Rotation Droite
            //arrete
            var temp = Right.Tuiles[0, 0];
            Right.Tuiles[0, 0] = Right.Tuiles[0, 2];
            Right.Tuiles[0, 2] = Right.Tuiles[2, 2];
            Right.Tuiles[2, 2] = Right.Tuiles[2, 0];
            Right.Tuiles[2, 0] = temp;

            //coin
            temp = Right.Tuiles[1, 0];
            Right.Tuiles[1, 0] = Right.Tuiles[0, 1];
            Right.Tuiles[0, 1] = Right.Tuiles[1, 2];
            Right.Tuiles[1, 2] = Right.Tuiles[2, 1];
            Right.Tuiles[2, 1] = temp;
        }
        public void RR()
        {
            RL();
            RL();
            RL();
        }

    }


}
