namespace Adapter
{
    public class Adult
    {
        public int Age { get; set; }

        public Adult(int age)
        {
            Age = age;
        }

        // Metoda sprawdzająca, czy osoba jest dorosła
        public virtual bool IsAdult()
        {
            return Age >= 18;
        }
    }
}
