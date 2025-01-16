namespace Adapter
{
    public class NightClub
    {
        public void CanEnter(Adult person)
        {
            if (person.IsAdult())
            {
                Console.WriteLine("Witaj w klubie!");
            }
            else
            {
                Console.WriteLine("Sorry, musisz mieć co najmniej 18 lat, aby wejść do klubu.");
            }
        }
    }

}
