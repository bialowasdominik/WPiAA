using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Konny : Wojownik
    {
        private string name;
        public Konny(string name) : base(name)
        {
            this.name = name;
        }

        public override void ShowWeapon()
        {
            Console.WriteLine($"I'm (konny) {name} and my weapon is horse");
        }
    }
}
