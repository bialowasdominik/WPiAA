using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Konny : Wojownik, IWarrior
    {
        private string name;
        public Konny(string name) : base(name)
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine("Konny attacks from horse");
        }

        public override void ShowWeapon()
        {
            Console.WriteLine($"I'm (konny) {name} and my weapon is horse");
        }
    }
}
