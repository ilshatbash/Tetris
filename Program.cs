using System;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Point p1 = new Point();
            p1.x = 5;
            p1.y = 6;
            p1.c = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 7;
            p2.c = '#';
            p2.Draw();


        }

        
    }
}
