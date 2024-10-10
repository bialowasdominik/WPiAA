using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PiechurBuilder : WarriorBuilder
    {
        public PiechurBuilder() 
        {
            warrior = new Piechur(Guid.NewGuid().ToString());
        }
        public override void ZapiszDoArmii()
        {
            Console.WriteLine("Piechur zapisany do armii.");
        }

        public override void PobierzBron()
        {
            Console.WriteLine("Piechur otrzymuje miecz.");
        }

        public override void TrenujWalka()
        {
            Console.WriteLine("Piechur trenuje walkę wręcz.");
        }
    }
}
