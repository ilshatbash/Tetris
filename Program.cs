using System;
using System.Threading;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

           // Figure[] f = new Figure[2];
           // f[0] = new Square(2, 4, '*');
           // f[1] = new Stick(6, 6, '*');

            Figure s = new Stick(5, 5, '*');
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();



            Thread.Sleep(500);
            s.Hide();
            s.Move(Directions.LEFT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Directions.LEFT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Directions.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Directions.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Directions.RIGHT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Directions.RIGHT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();

            //Stick s = new Stick(5, 6, '*');
            //s.Draw();

            //Point p1 = new Point(2,3,'*');
            //p1.Draw();

            //foreach(Figure fig in f)
            // {
            //   fig.Draw();
            //}
            /*
            Point p2 = new Point()
            { 
            x = 5,
            y = 10,
            c='$'        
            };
            p2.Draw();
            Console.ReadLine();
            */

        }

        
    }
}
