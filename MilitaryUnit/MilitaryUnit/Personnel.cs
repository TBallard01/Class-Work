using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Personnel
    {

        public virtual void Move() => Console.WriteLine("Running");
        public virtual void Eat() => Console.WriteLine("Eats an MRE");
        public virtual void Sleep() => Console.WriteLine("Snores");
        public virtual void Yell() => Console.WriteLine("AHHHHHHHH!");
        public virtual void Work() => Console.WriteLine("Marine is working");
        public virtual void FireWatch() => Console.WriteLine("The marine patrols around the position staying alert, in case of an ambush.");
        public virtual void WakeUp() => Console.WriteLine("The marine wakes up.");
        public virtual void Injured() => Console.WriteLine("I don't feel so good.");
        public void FirstAid()
        {
            Random rndm = new Random();
            int chance = rndm.Next(1, 3);
            if (chance == 1)
            {
                Console.WriteLine("Marine administers first aid. The injured marine is going to be alright.");
            }
            else
            {
                Console.WriteLine("Marine administers first aid. The injured marine died.");
            }
        }

        public enum DirectionOfFire {front, rear, left, right}

        public virtual void Contact()
        {
            DirectionOfFire takingFire = (DirectionOfFire)(new Random()).Next(0,5);
            switch (takingFire)
            {
                case DirectionOfFire.front:
                    {
                        Console.WriteLine("Contact front!");
                        break;
                    }
                case DirectionOfFire.rear:
                    {
                        Console.WriteLine("Contact from the rear!");
                        break;
                    }
                case DirectionOfFire.left:
                    {
                        Console.WriteLine("Contact left!");
                        break;
                    }
                case DirectionOfFire.right:
                    {
                        Console.WriteLine("Contact right!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The direction of fire is unknown");
                        break;
                    }
            }
                
        }
    }
    class PrivateFirstClass : Personnel
    {       
        public override void Eat() => Console.WriteLine("The PFC eats an MRE.");
        public override void Work() => Console.WriteLine("The PFC is setting up the cammie net.");
        public override void FireWatch() => Console.WriteLine("The PFC patrols around the position staying alert, in case of an ambush.");
        public override void Sleep() => Console.WriteLine("The PFC is sleeping.");
        public override void WakeUp() => Console.WriteLine("The PFC wakes up.");
        public override void Yell() => Console.WriteLine("PFC yells: AHHHHHHH");
        public override void Contact()
        {
            DirectionOfFire takingFire = (DirectionOfFire)(new Random()).Next(0, 5);
            switch (takingFire)
            {
                case DirectionOfFire.front:
                    {
                        Console.WriteLine("PFC screams: Contact front!");
                        break;
                    }
                case DirectionOfFire.rear:
                    {
                        Console.WriteLine("PFC screams: Contact from the rear!");
                        break;
                    }
                case DirectionOfFire.left:
                    {
                        Console.WriteLine("PFC screams: Contact left!");
                        break;
                    }
                case DirectionOfFire.right:
                    {
                        Console.WriteLine("PFC screams: Contact right!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("PFC screams: The direction of fire is unknown");
                        break;
                    }
            }
        }
        public override void Move() => Console.WriteLine("The PFC starts running.");
        public override void Injured() => Console.WriteLine("LCpl, I don't feel so good.");
    }
    class LanceCorporal : Personnel
    {
        public override void Eat() => Console.WriteLine("The LCpl eats an MRE.");
        public override void Work() => Console.WriteLine("The LCpl is making a range card for his stinger position.");
        public override void FireWatch() => Console.WriteLine("The LCpl patrols around the position staying alert, in case of an ambush.");
        public override void Sleep() => Console.WriteLine("The LCpl is sleeping.");
        public override void WakeUp() => Console.WriteLine("The LCpl wakes up.");
        public override void Yell() => Console.WriteLine("LCpl yells: AHHHHHHH");
        public override void Contact()
        {
            DirectionOfFire takingFire = (DirectionOfFire)(new Random()).Next(0, 5);
            switch (takingFire)
            {
                case DirectionOfFire.front:
                    {
                        Console.WriteLine("LCpl screams: Contact front!");
                        break;
                    }
                case DirectionOfFire.rear:
                    {
                        Console.WriteLine("LCpl screams: Contact from the rear!");
                        break;
                    }
                case DirectionOfFire.left:
                    {
                        Console.WriteLine("LCpl screams: Contact left!");
                        break;
                    }
                case DirectionOfFire.right:
                    {
                        Console.WriteLine("LCpl screams: Contact right!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("LCpl screams: The direction of fire is unknown");
                        break;
                    }
            }
        }
        public override void Move() => Console.WriteLine("The LCpl starts running.");
        public override void Injured() => Console.WriteLine("Cpl, I don't feel so good.");
    }
    class Corporal : Personnel
    {
        public override void Eat() => Console.WriteLine("The Cpl eats an MRE.");
        public override void Work() => Console.WriteLine("The Cpl is making a range card for the crew serve weapon.");
        public override void FireWatch() => Console.WriteLine("The Cpl patrols around the position staying alert, in case of an ambush.");
        public override void Sleep() => Console.WriteLine("The Cpl is sleeping.");
        public override void WakeUp() => Console.WriteLine("The Cpl wakes up.");
        public override void Yell() => Console.WriteLine("Cpl yells: AHHHHHHH");
        public override void Contact()
        {
            DirectionOfFire takingFire = (DirectionOfFire)(new Random()).Next(0, 5);
            switch (takingFire)
            {
                case DirectionOfFire.front:
                    {
                        Console.WriteLine("Cpl screams: Contact front!");
                        break;
                    }
                case DirectionOfFire.rear:
                    {
                        Console.WriteLine("Cpl screams: Contact from the rear!");
                        break;
                    }
                case DirectionOfFire.left:
                    {
                        Console.WriteLine("Cpl screams: Contact left!");
                        break;
                    }
                case DirectionOfFire.right:
                    {
                        Console.WriteLine("Cpl screams: Contact right!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("CPl screams: The direction of fire is unknown");
                        break;
                    }
            }
        }
        public override void Move() => Console.WriteLine("The Cpl starts running.");
        public override void Injured() => Console.WriteLine("Sgt, I don't feel so good.");
    }
    class Sergreant : Personnel
    {
        public override void Eat() => Console.WriteLine("You eat an MRE.");
        public override void Work() => Console.WriteLine("You are in the truck plotting mission related information on your map, and monitoring communications.");
        public override void FireWatch() => Console.WriteLine("You are patroling around the position staying alert, in case of an ambush.");
        public override void Sleep() => Console.WriteLine("You are sleeping.");
        public override void WakeUp() => Console.WriteLine("You wake up.");
        public override void Yell() => Console.WriteLine("You yell: AHHHHHHH");
        public override void Contact()
        {
            DirectionOfFire takingFire = (DirectionOfFire)(new Random()).Next(0, 5);
            switch (takingFire)
            {
                case DirectionOfFire.front:
                    {
                        Console.WriteLine("You scream: Contact front!");
                        break;
                    }
                case DirectionOfFire.rear:
                    {
                        Console.WriteLine("You scream: Contact from the rear!");
                        break;
                    }
                case DirectionOfFire.left:
                    {
                        Console.WriteLine("You scream: Contact left!");
                        break;
                    }
                case DirectionOfFire.right:
                    {
                        Console.WriteLine("You scream: Contact right!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You scream: The direction of fire is unknown");
                        break;
                    }
            }
        }
        public override void Move() => Console.WriteLine("You start running.");
        public override void Injured() => Console.WriteLine("Mr. Stark, I don't feel so good.");
    }

}
