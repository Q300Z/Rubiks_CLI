namespace TBO_Rubiks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le Rubik's Cube");
            

            Cube cube = new Cube(6, 2);

            while (true)
            {
                cube.Display();
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D:
                        if (key.Modifiers == 0)
                        {
                            cube.DL();
                        }
                        else if (key.Modifiers == ConsoleModifiers.Shift)
                        {
                            cube.DR();
                        }
                        break;
                    case ConsoleKey.U:
                        if (key.Modifiers == 0)
                        {
                            cube.UL();
                        }
                        else if (key.Modifiers == ConsoleModifiers.Shift)
                        {
                            cube.UR();
                        }

                        break;
                    case ConsoleKey.B:
                        if (key.Modifiers == 0)
                        {
                            cube.B();
                        }
                        else if (key.Modifiers == ConsoleModifiers.Shift)
                        {
                            cube.BP();
                        }
                        break;
                    case ConsoleKey.F:
                        if (key.Modifiers == 0)
                        {
                            cube.F();
                        }
                        else if (key.Modifiers == ConsoleModifiers.Shift)
                        {
                            cube.FP();
                        }
                        break;
                    case ConsoleKey.L:
                        if (key.Modifiers == 0)
                        {
                            cube.LL();
                        }
                        else if (key.Modifiers == ConsoleModifiers.Shift)
                        {
                            cube.LR();
                        }
                        break;
                    case ConsoleKey.R:
                        if (key.Modifiers == 0)
                        {
                            cube.RL();
                        }
                        else if (key.Modifiers == ConsoleModifiers.Shift)
                        {
                            cube.RR();
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        cube.reset();
                        break;
                    default: break;
                }
            }
        }
    }
}