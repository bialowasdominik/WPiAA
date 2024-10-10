using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class StrzelecBuilder : WarriorBuilder
    {
        public StrzelecBuilder()
        {
            warrior = new Strzelec(Guid.NewGuid().ToString());
        }
        public override void ZapiszDoArmii()
        {
            Console.WriteLine("Strzelec zapisany do armii.");
        }

        public override void PobierzBron()
        {
            Console.WriteLine("Strzelec otrzymuje miecz.");
        }

        public override void TrenujWalka()
        {
            Console.WriteLine("Strzelec trenuje walkę wręcz.");
        }
    }
}
