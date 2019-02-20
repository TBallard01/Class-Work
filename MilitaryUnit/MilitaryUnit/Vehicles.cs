using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Vehicles
    {
        public void Load() => Console.WriteLine("All your teams' gear is loaded onto the vehicle, and your team enters the vehicle.");
        public void Unload() => Console.WriteLine("All your teams' gear is unloaded from the vehicle, and your team exits the vehicle.");
        public void Refuel() => Console.WriteLine("The vehicle has been refueled.");
        public virtual void Drive() => Console.WriteLine("BBRRRMMMM PUT PUT PUT BBRRRMMMM");
        public void Brake() => Console.WriteLine("SCREECH!");
        public void Turn(string turnDirection)
        {
            if (turnDirection == "Right")
            {
                Console.WriteLine("Driver turns to the right.");
            }
            if (turnDirection == "Left")
            {
                Console.WriteLine("Driver turns to the left.");
            }
            if (turnDirection == "U-turn")
            {
                Console.WriteLine("Driver makes a u-turn. You all are headed back.");
            }
        }

        public void Horn() => Console.WriteLine("HONK! HONK!");
    }

        class HMMWV : Vehicles
        {

        }
        class RAZR : Vehicles
        {
            public override void Drive() => Console.WriteLine("Skrt Skrt");
        }
        class SevenTon : Vehicles
        {

        }
    
}
