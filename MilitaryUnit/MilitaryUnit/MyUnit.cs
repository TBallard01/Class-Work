using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MyUnit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are a sergeant in a 3D Low Altitude Air Defense Unit aka LAADSOC. You are leading a team " +
                "of 3 other marines, a Corporal, Lance Corporal, and a Private First Class. Your team is deployed in " +
                "Iraq. You have been instructed to go to an 8 digit grid location and establish a stinger position.");
            Console.WriteLine();

            //Appendix
            Iraq iraq = new Iraq();
            M16A4 m16a4 = new M16A4();
            M4 m4 = new M4();
            RAZR razr = new RAZR();
            PrivateFirstClass pfc = new PrivateFirstClass();
            LanceCorporal lcpl = new LanceCorporal();
            Corporal cpl = new Corporal();
            Sergreant sgt = new Sergreant();
            //End of appendix

            iraq.TypeOfTerrain("Iraq");
            iraq.WeatherOfTheDay();

            razr.Load();
            razr.Drive();
            razr.Turn("Right");
            razr.Drive();
            razr.Turn("Left");
            razr.Drive();
            razr.Brake();
            razr.Unload();
            Console.WriteLine();
            
            pfc.Work();
            lcpl.Work();
            cpl.Work();
            sgt.Work();
            Console.WriteLine();

            Console.WriteLine("It has been 6 hours and the marines begin to get hungry.");
            Console.WriteLine();

            pfc.Eat();
            lcpl.Eat();
            cpl.Eat();
            sgt.Eat();
            Console.WriteLine();

            Console.WriteLine("It is now 20:00 and time for you and your team to get some rest. You assign the Private First Class, and Corporal to take first firewatch while everyone else gets some sleep.");
            Console.WriteLine();

            pfc.FireWatch();
            cpl.FireWatch();
            lcpl.Sleep();
            sgt.Sleep();
            Console.WriteLine();

            Console.WriteLine("After a few hours of sleep....");
            Console.WriteLine();

            pfc.Yell();
            Console.WriteLine("BANG! BANG! BANG!");
            cpl.Contact();
            Console.WriteLine();

            lcpl.WakeUp();
            sgt.WakeUp();
            Console.WriteLine("The Lance Corporal grabs his M16A4, and heads towards the threat.");
            Console.WriteLine("You grab your M4, and head toward the threat.");
            Console.WriteLine();

            m16a4.Aim();
            m16a4.Shoot("Sharp Shooter");
            Console.WriteLine();

            m4.Aim();
            m4.Shoot("Expert");
            Console.WriteLine();

            Console.WriteLine("You have repelled the threat, and notice the PFC has been shot.");
            pfc.Injured();
            lcpl.FirstAid();
            Console.WriteLine();

            iraq.MissionSuccess();

            Console.ReadKey();
        }
    }
}
