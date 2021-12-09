using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TTTGrid
    {
        static int[] grid = new int[9];
        static void Main(string[] args)
        {

            
            grid[0] = 0;
            grid[1] = 0;
            grid[2] = 0;
            grid[3] = 0;
            grid[4] = 0;
            grid[5] = 0;
            grid[6] = 0;
            grid[7] = 0;
            grid[8] = 0;



            while (true)
            {
               
                Console.WriteLine("Pick a number between 0-8");
                int playerMove = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You typed " + playerMove);

                grid[playerMove] = 1;
                generateGrid();
            }

            Console.ReadLine();






        }

        public static void generateGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[i] == 0) //Unused Spot
                {
                    Console.Write("_");
                }
                if (grid[i] == 1) //Player 1
                {
                    Console.Write("X");
                }
                if (grid[i] == 2) //Player 2
                {
                    Console.Write("O");
                }

                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
                
                
        }


    }
