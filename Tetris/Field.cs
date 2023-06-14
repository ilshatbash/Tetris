using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
   static class Field
    {
        private static int _widht = 20;
        private static int _height = 20;

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

        public static void TryDeleteLines()
        {
            for (int j = 0; j < Height; j++) 
            {
                int counter = 0;
                for (int i = 0;i<Widht; i++)
                {
                    if (_heap[j][i])
                        counter++;
                }
                if (counter == Widht)
                {
                    DeleteLine(j);
                    Redraw();
                }
            }
            
        }

        private static void Redraw()
        {
            for(int j = 0; j < Height; j++)
            {
                for(int i=0; i<Widht; i++)
                {
                    if (_heap[j][i])
                        Drawer.DrawPoint(i, j);
                    else
                        Drawer.HidePoint(i, j);
                }
            }
        }

        private static void DeleteLine(int line)
        {
            for(int j = line; j >=0; j--)
            {
                for(int i  = 0; i < Widht; i++)
                {
                    if (j == 0)
                        _heap[j][i] = false;
                    else
                        _heap[j][i] = _heap[j-1][i];

                }
            }
        }
    }
}
