using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Deployments
    {
        public void MissionSuccess()
        {
            Random rndm = new Random();
            int chance = rndm.Next(1, 3);
            if (chance == 1)
            {
                Console.WriteLine("Mission Completed.");
            }
            else
            {
                Console.WriteLine("Mission Failed.");
            }
        }
        public enum Weather { Raining, Sunshine, Overcast, Snowing }
        public void WeatherOfTheDay()
        {
            Weather weather = (Weather)(new Random()).Next(0, 4);
            switch (weather)
            {
                case Weather.Raining:
                    {
                        Console.WriteLine("It is raining heavily.");
                        Console.WriteLine();
                        break;
                    }
                case Weather.Sunshine:
                    {
                        Console.WriteLine("It is bright, and very hot.");
                        Console.WriteLine();
                        break;
                    }
                case Weather.Overcast:
                    {
                        Console.WriteLine("It is cloudy out. The weather is nice today.");
                        Console.WriteLine();
                        break;
                    }
                case Weather.Snowing:
                    {
                        Console.WriteLine("It is snowing heavily. The weather outside is frightful.");
                        Console.WriteLine();
                        break;
                    }
            }
        }
        public void TypeOfTerrain(string location)
        {
            if (location == "Iraq")
            {
                Console.WriteLine("Iraq is a barren area of landscape where little precipitation occurs and, consequently, living conditions are hostile for plant and animal life.");
            }
            else if (location == "Russia")
            {
                Console.WriteLine("The Russian landscape varies from desert to frozen coastline, tall mountains to giant marshes. Much of Russia is made up of rolling, treeless plains called steppes. Siberia, which occupies three-quarters of Russia, is dominated by sprawling pine forests called taigas.");
            }
            else if (location == "Syria")
            {
                Console.WriteLine("A flat desert plateau, dissected by mountains with a narrow coastal plain that fronts the Mediterranean Sea. In the west-central and north the Anti-Lebanon and Bishri mountains dominate the landscape. The highest point, Mt Hermon, stands in the far southwest at 9,232 ft.");
            }
            else if (location == "Japan")
            {
                Console.WriteLine("Japan is mountainous, with a mountain range running through each of the main islands. Japan's highest mountain is Mount Fuji, with an elevation of 3,776 m (12,388 ft). Japan's forest cover rate is 68.55% since the mountains are heavily forested.");
            }
            else
            {
                Console.WriteLine("You are not deployed, and are with your current unit probably hating your life.");
            }
        }
    }
        class Iraq : Deployments
        {

        }
        class Russia : Deployments
        {
            
        }
        class Syria : Deployments
        {

        }
        class Japan : Deployments
        {

        }
        class NotDeployed : Deployments
        {

        }
    
}

