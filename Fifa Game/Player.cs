using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_Advanced_C__G02_Demo.Fifa_Game
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }

        //Call Back Function
        public void Run(Ball ball)
        {
            Console.WriteLine($"Player: {PlayerName} is Running To {ball}");
        }

    }

}
