using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK
{
    public class Game
    {
        public Team TeamOne { get; set; }
        public Team TeamTwo { get; set; }
        public Referee GameReferee { get; }

        public List<Goal> Goals { get; }

        public string GameResult { get; set; }
        public string Winner { get; set; }
        public Game()
        {
            TeamOne = new Team();
            TeamTwo = new Team();
            GameReferee = new Referee();
            Goals = new List<Goal>();
        }

    }

   
}
