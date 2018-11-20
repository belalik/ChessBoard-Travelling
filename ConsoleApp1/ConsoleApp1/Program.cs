using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board chessBoard = new Board();

            chessBoard.printALine(Convert.ToInt16(Console.ReadLine())); 
        }
    }

    class Board
    {
        public Cell[,] TheBoard { get; set; }

        public Board()
        {
            TheBoard = new Cell[8, 8];
            bool white = true;
            int x = 1;

            for (int i=0; i<8; i++)
            {
                int y = 8;
                for (int j=0; j<8; j++)
                {
                    
                    if (white)
                    {
                        TheBoard[i, j] = new Cell(x, y, 0);
                        Console.WriteLine("ftiaxnw white at: ("+x+","+y+")");
                    }
                    else
                    {
                        Console.WriteLine("ftiaxnw black at: (" + x + "," + y + ")");
                        TheBoard[i, j] = new Cell(x, y, 1);
                    }
                    white = !white;
                    y--;
                }
                x++;
            }
        }
            
        public void printALine(int num)
        {
            for (int i=0; i<8; i++)
            {
                Console.WriteLine("("+TheBoard[i,num].X + ","+ TheBoard[i, num].Y+") "+ TheBoard[i, num].ColorString);
            }
        }
    }


    class Cell
    {

        public Cell(int x, int y, int colorvalue)
        {
            X = x;
            Y = y;
            
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Color { get; set; }

        public string ColorString
        {
            get
            {
                if (Color==0)
                {
                    return "White";
                }
                else
                {
                    return "Black";
                }
            }
        }
    }
}
