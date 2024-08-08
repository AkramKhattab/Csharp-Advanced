using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_Advanced_C__G02_Demo.Fifa_Game
{
    internal class Refree
    {
        public string RefreeName { get; set; }
        public void Look(Ball ball)
        {
            Console.WriteLine($"Refree: {RefreeName} is Looking At {ball}");
        }


    }
}
