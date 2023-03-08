using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBO_Rubiks
{
    internal class Cube
    {
        public int LargeurTuile { get; set; } = 2;
        public Face Top { get; set; } = new Face("W");
        public Face Bottom { get; set; } = new Face("Y");
        public Face Front { get; set; } = new Face("R");
        public Face Back { get; set; } = new Face("O");
        public Face Left { get; set; } = new Face("G");
        public Face Right { get; set; } = new Face("B");

        public Cube()
        {
            Top = new Face("W", LargeurTuile);
            Bottom = new Face("Y", LargeurTuile);
            Front = new Face("R", LargeurTuile);
            Back = new Face("O", LargeurTuile);
            Left = new Face("G", LargeurTuile);
            Right = new Face("B", LargeurTuile);
        }
        public void Display()
        {
            Top.Display(3 * LargeurTuile, 1);
            Left.Display(0, 4);
            Front.Display(3 * LargeurTuile, 4);
            Right.Display(3 * 2 * LargeurTuile, 4);
            Back.Display(3 * 3 * LargeurTuile, 4);
            Bottom.Display(3 * LargeurTuile, 7);
        }
    }

}
