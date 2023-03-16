namespace TBO_Rubiks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Cube cube = new Cube(4,2);

            while (true)
            {
                cube.Display();

                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.DownArrow:
                        break;
                    case ConsoleKey.LeftArrow:
                        cube.FP();
                        break;
                    case ConsoleKey.RightArrow:
                        cube.F();
                        break;
                    case ConsoleKey.Spacebar:
                        break;
                    default: break;
                }
            }           
        }
    }
}