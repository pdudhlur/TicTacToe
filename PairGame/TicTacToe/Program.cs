using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
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


            while (winner() ==0)
            {

                Console.WriteLine("Player 1: Pick a number between 0-8");
                int player1Move = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Player 1 chose " + player1Move);

                grid[player1Move] = 1;
                generateGrid();

                

                Console.WriteLine("Player 2: Pick a number between 0-8");
                int player2Move = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Player 2 chose " + player2Move);

                grid[player2Move] = 2;
                generateGrid();
            }

            Console.WriteLine("Player " + winner() + "is the winner!");
  


            Console.ReadLine();


        }

        public static void generateGrid() //Creates Board
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

        public static int winner() //Determines winner. Switch or Ifs
        {
            if (grid[0] == grid[1] && grid[0] == grid[2])
            {
                return grid[0];
            }
            if (grid[3] == grid[4] && grid[3] == grid[5])
            {
                return grid[3];
            }
            if (grid[6] == grid[7] && grid[6] == grid[8])
            {
                return grid[6];
            }


            if (grid[0] == grid[3] && grid[0] == grid[6])
            {
                return grid[0];
            }
            if (grid[1] == grid[4] && grid[1] == grid[7])
            {
                return grid[1];
            }
            if (grid[2] == grid[5] && grid[2] == grid[8])
            {
                return grid[2];
            }
            return 0;
        }   




    }
}
