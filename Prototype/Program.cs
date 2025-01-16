using Newtonsoft.Json;
namespace Prototype
{
    public class Ork
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public Ork(string name, int strength, int agility)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
        }

        public Ork Clone()
        {
            string json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Ork>(json);
        }

        public override string ToString()
        {
            return $"Ork: {Name}, Strength: {Strength}, Agility: {Agility}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Ork originalOrk = new Ork("Goroth", 100, 50);
            List<Ork> orkClones = new List<Ork>();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Ork clonedOrk = originalOrk.Clone();
                clonedOrk.Strength = random.Next(80, 120);
                orkClones.Add(clonedOrk);
            }

            Console.WriteLine("Oryginalny Ork:");
            Console.WriteLine(originalOrk);

            Console.WriteLine("\nKlonowane Orki:");
            foreach (var ork in orkClones)
            {
                Console.WriteLine(ork);
            }
        }
    }
}
