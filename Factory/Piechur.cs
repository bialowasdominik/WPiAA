namespace Factory
{
    public class Piechur : Wojownik
    {
        private string name;
        public Piechur(string name) : base(name) 
        {
            this.name = name;
        }

        public override void ShowWeapon()
        {
            Console.WriteLine($"I'm (piechur) {name} and my weapon is spear");
        }
    }
}
