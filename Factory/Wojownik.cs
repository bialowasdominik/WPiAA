namespace Factory
{
    public abstract class Wojownik
    {
        private string name = "";

        public Wojownik(string name) 
        { 
            this.name = name;
        }

        public abstract void ShowWeapon();
    }
}
