using System;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Square(2, 4, '*');
            f[1] = new Stick(6, 6, '*');

            //Square s = new Square(2, 5, '*');
            //s.Draw();
            //Stick s = new Stick(5, 6, '*');
            //s.Draw();

            //Point p1 = new Point(2,3,'*');
            //p1.Draw();

            foreach(Figure fig in f)
            {
                fig.Draw();
            }

            Point p2 = new Point()
            { 
            x = 5,
            y = 10,
            c='$'        
            };
            p2.Draw();
            Console.ReadLine();


        }

        
    }
}
