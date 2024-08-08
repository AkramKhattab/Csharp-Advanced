using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_04_Advanced_C__G02_Demo.Fifa_Game
{
    internal class Ball
    {

        public int Id { get; set; }

        private Location location;





        public Location Location
        {
            get { return location; }


            //EVENT
            set
            {

                if (value.Equals(location))
                {
                    location = value;

                    // Notify Subscriber

                    BallLocationChanged?.Invoke(this);
                }

            }

        }

        public event Action<Ball> BallLocationChanged;



        public override string ToString()
        {
            return $"Id: {Id}, Location: {Location}";
        }
    }
}
