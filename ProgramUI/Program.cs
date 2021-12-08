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


            }


            return;
        }

        public void ShowMenu()
        {
            Console.WriteLine("Select an option:\n" +
                "[1] - Play");
            string userInput = Console.ReadLine();

        }
    }
}
