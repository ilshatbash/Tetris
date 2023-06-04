using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Point
    {
        public int x;
        public int y;
        public char c;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        internal void Move(Directions dir)
        {
           switch(dir)
            {
                case Directions.DOWN:y += 1; break;
                    case Directions.LEFT: x -= 1; break;
                    case Directions.RIGHT: x += 1; break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public Point(int a, int b,char sym)
        {
            x = a;
            y = b;
            c = sym;
        }
        public Point() { }
    }
}
