using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.WIDHT, Field.HEIGHT);
            Console.SetBufferSize(Field.WIDHT, Field.HEIGHT);

            FigureGenerator generator = new FigureGenerator(20, 0, '$');
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
                    curerrentFigure.TryMove(Direction.LEFT); break;    
               case ConsoleKey.RightArrow:
                    curerrentFigure.TryMove(Direction.RIGHT); break;
                case ConsoleKey.DownArrow:
                    curerrentFigure.TryMove(Direction.DOWN);break;
                case ConsoleKey.Spacebar:                    
                    curerrentFigure.TryRotate();                    
                    break;

            }
        }
    }
}
