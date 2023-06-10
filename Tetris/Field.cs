using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
   static class Field
    {
        private static int _widht = 40;
        private static int _height = 30;

        public static int Widht
        {
            get
            {
                return _widht;
            }
            set
            {
                _widht = value;
                Console.SetWindowSize(Field._widht, Field.Height);
                Console.SetBufferSize(Field._widht, Field.Height);
            }
        }
        public static int Height
        {
            get 
            {
                return _height;
            }
            set
            {
                _height= value;
                Console.SetWindowSize(value, Field.Height);
                Console.SetBufferSize(value, Field.Height);

            }
        }
        private static bool[][] _heap;
        static Field()
        {
            _heap = new bool[Height][];
            for (int i = 0; i < Height; i++)
            {
                _heap[i]= new bool[Widht];
            } 
        }
        public static bool CheckStrike(Point p)
        {
            return _heap[p.X][p.Y];
        }
        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points ) 
            {
                _heap[p.X][ p.Y] = true;
            }
        }
       
    }
}
