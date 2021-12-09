using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    // Tic Tac Toe program by Prasanth and AJ
    internal class Program
    {
        private string _userInput = "";

        public void Main(string[] args)
        {
            RunProgram();

        }

        public void RunProgram()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                ShowMenu();
                switch(_userInput)
                {
                    case "1":
                        // play game
                        Console.WriteLine("Play Game");
                        break;
                    case "2":
                        ShowStats();
                        break;
                    case "9":
                        Console.WriteLine("Quitting...");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        System.Threading.Thread.Sleep(2500);
                        break;
                }

            }


            return;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(
                " *****************************\n" +
                "*** Welcome to Tic Tac Toe! ***\n" +
                " *****************************\n\n\n");
            Console.WriteLine(
                "Select an option:\n" +
                "[1] - Play\n" +
                "[2] - Display Current Stats\n" +
                "[9] - Quit\n");
            _userInput = Console.ReadLine();
            return;
        }

        public void ShowStats()
        {
            Console.Clear();
            Console.WriteLine(
                " *****************************\n" +
                "********     Stats     ********\n" +
                " *****************************\n\n\n");
            // Show each player's name, total games, total wins, and points

        }
    }
}
