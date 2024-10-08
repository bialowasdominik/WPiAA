using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Strzelec : Wojownik
    {
        private string name;
        public Strzelec(string name) : base(name)
        {
            this.name = name;
        }

        public override void ShowWeapon()
        {
            Console.WriteLine($"I'm (strzelec) {name} and my weapon is bow");
        }
    }
}
