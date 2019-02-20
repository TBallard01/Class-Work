using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Weapons
    {
        public virtual void Aim() => Console.WriteLine("Marine aims his weapon at a confirmed hostile.");
        public void Shoot(string shootingQualifications)
        {
            if (shootingQualifications == "Expert")
            {
                Console.WriteLine("Marine shoots at hostile. Confirmed kill.");
            }
            if (shootingQualifications == "Sharp Shooter")
            {
                Random rndm = new Random();
                int chance = rndm.Next(1, 3);
                if (chance == 1)
                {
                    Console.WriteLine("Marine shoots at hostile. Confirmed kill.");
                }
                else
                {
                    Console.WriteLine("Marine shoots at hostile. Marine missed.");
                }
            }
            if (shootingQualifications == "Marksman")
            {
                Console.WriteLine("Marine shoots at hostile. Marine missed.");
            }
        }
        public virtual void Reload() => Console.WriteLine("Drops old mag, and inserts a new one of 30 rounds.");
        public void SafetyOn() => Console.WriteLine("The weapon is on safe.");
        public void CleanWeapon() => Console.WriteLine("The weapon is clean.");
    }

        class M16A4 : Weapons
        {
            public override void Aim() => Console.WriteLine("Marine aims his M16A4 at a confirmed hostile.");
        }
        class M4 : Weapons
        {
            public override void Aim() => Console.WriteLine("Marine aims his M4 at a confirmed hostile.");
        }
        class M240B : Weapons
        {
            public override void Reload() => Console.WriteLine("Takes a new belt of 7.62 ammunition, loads it onto the feed tray, racks the bolt charging handle back, and then pushes it forward.");
            public override void Aim() => Console.WriteLine("Marine aims the 240 at a confirmed hostile.");
        }
        class FiftyCal : Weapons
        {
            public override void Reload() => Console.WriteLine("Takes a new belt of 50 cal ammunition, loads it onto the feed tray, and slingshots the bolt charging handle.");
            public override void Aim() => Console.WriteLine("Marine aims the 50cal at a confirmed hostile.");
        }
        class StingerMissile : Weapons
        {
            public override void Reload() => Console.WriteLine("Removes the BCU, takes the gripstock off the expended missile tube, inserts BCU into gripstock, and puts it on a new missile tube.");
            public override void Aim() => Console.WriteLine("Marine aims the stinger missile at a confirmed hostile.");
        }
    
}
