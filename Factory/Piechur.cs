using Builder;

namespace Factory
{
    public class Piechur : Wojownik, IWarrior
    {
        private string name;
        public Piechur(string name) : base(name) 
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine("Piechur attacks with spear");
        }

        public override void ShowWeapon()
        {
            Console.WriteLine($"I'm (piechur) {name} and my weapon is spear");
        }
    }
}
