using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class KonnyBuilder : WarriorBuilder
    {
        public KonnyBuilder()
        {
            warrior = new Konny(Guid.NewGuid().ToString());
        }
        public override void ZapiszDoArmii()
        {
            Console.WriteLine("Konny zapisany do armii.");
        }

        public override void PobierzBron()
        {
            Console.WriteLine("Konny otrzymuje miecz.");
        }

        public override void TrenujWalka()
        {
            Console.WriteLine("Konny trenuje walkę wręcz.");
        }
    }
}
