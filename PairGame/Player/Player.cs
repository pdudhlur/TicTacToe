using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Player
    {
        public string Name { get; set; }
        public char Team { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int TotalPoints { get; set; }

        public Player() { }
        public Player(string name, char team)
        {
            Name = name;
            Team = team;
        }

        public void WonGame(int points)
        {
            GamesPlayed++;
            GamesWon++;
            TotalPoints += points;
        }

        public void LostGame(int points)
        {
            GamesPlayed++;
            TotalPoints -= points;
        }
    }
}



