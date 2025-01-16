namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NightClub nightClub = new();
            Adult doroslaOsoba = new(25);
            FakeAdult krzys = new(17);

            nightClub.CanEnter(doroslaOsoba);
            nightClub.CanEnter(krzys);
        }
    }
}
