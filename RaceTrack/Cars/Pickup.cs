using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Pickup : RaceCar
    {
        public Pickup()
        {
            Name = "Pickup";
            TopSpeed = 150;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Name} revs away!");
        }

        public override void StopEngine()
        {

            Console.WriteLine($"{Name} says Home Depot is my stop.");
        }

        public override void Brake()
        {
            Console.WriteLine($"{Name} hits the breaks!!!");
            base.Brake();
        }
    }
}
