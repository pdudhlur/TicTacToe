using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TTTGrid
    {
        
        static void Main(string[] args)
        {

            int[] grid = new int[9];
            grid[0] = 2;
            grid[1] = 0; 
            grid[2] = 1;
            grid[3] = 0;
            grid[4] = 0;
            grid[5] = 1;
            grid[6] = 0;
            grid[7] = 0;
            grid[8] = 2;



            for (int i = 0; i < 9; i++)
            {
                if (grid[i] == 0)
                {
                    Console.Write("_");
                }
                if (grid[i] == 1)
                {
                    Console.Write("X");
                }
                if (grid[i] == 2)
                {
                    Console.Write("O");
                }

                if (i == 2)
                {
                    Console.WriteLine();
                }
                if (i == 5)
                {
                    Console.WriteLine();
                }
                if (i == 8)
                {
                    Console.WriteLine();
                }
            }


            int userMove = Convert.ToInt32(Console.ReadLine());


            Console.ReadLine();






        }

        
}
