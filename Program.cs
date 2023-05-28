using System;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            int x1 = 2;
            int y1= 3;
            char c1 = '*';
            Drow(x1, y1, c1);
           

            int x2 = 9;
            int y2= 7;
            char c2 = '#';
            Drow(x2, y2, c2);

        }

        private static void Drow(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
