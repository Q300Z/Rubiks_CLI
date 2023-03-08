using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBO_Rubiks
{
    internal class Cube
    {
        public int LargeurTuile { get; set; } = 5;
        public int HauteurTuile { get; set; } = 3;
        public Face Top { get; set; } = new Face("W");
        public Face Bottom { get; set; } = new Face("Y");
        public Face Front { get; set; } = new Face("R");
        public Face Back { get; set; } = new Face("O");
        public Face Left { get; set; } = new Face("G");
        public Face Right { get; set; } = new Face("B");

        public Cube()
        {
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
            Front.Display(3 * LargeurTuile, 1+(3*HauteurTuile));
            Right.Display(3 * 2 * LargeurTuile, 1 + (3 * HauteurTuile));
            Back.Display(3 * 3 * LargeurTuile, 1 + (3 * HauteurTuile));
            Bottom.Display(3 * LargeurTuile, 1 + (2*3 * HauteurTuile));
        }
    }

}
