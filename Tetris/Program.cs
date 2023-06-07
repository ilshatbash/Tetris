using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure curerrentFigure=generator.GetNewFigure();

            while (true)
            {
               if(Console.KeyAvailable)
                {
                   ConsoleKeyInfo key= Console.ReadKey();
                    HandleKey(curerrentFigure, key);

                }
            }
        }

        private static void HandleKey(Figure curerrentFigure, ConsoleKeyInfo key)
        {
           switch(key.Key)
            {
                case ConsoleKey.LeftArrow:
                    curerrentFigure.Move(Direction.LEFT); break;    
                case ConsoleKey.RightArrow:
                    curerrentFigure.Move(Direction.RIGHT); break;
                case ConsoleKey.DownArrow:
                    curerrentFigure.Move(Direction.DOWN);break;

            }
        }
    }
}
