namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wojownik[] wojowniks = new Wojownik[10];

            wojowniks[0] = Garnizon.TrainWarrior("peichur", "Jan");
            wojowniks[1] = Garnizon.TrainWarrior("peichur", "Tomasz");
            wojowniks[2] = Garnizon.TrainWarrior("peichur", "Wojciech");
            wojowniks[3] = Garnizon.TrainWarrior("konny", "Jan");
            wojowniks[4] = Garnizon.TrainWarrior("konny", "Tomasz");
            wojowniks[5] = Garnizon.TrainWarrior("konny", "Wojciech");
            wojowniks[6] = Garnizon.TrainWarrior("strzelec", "Jan");
            wojowniks[7] = Garnizon.TrainWarrior("strzelec", "Tomasz");
            wojowniks[8] = Garnizon.TrainWarrior("strzelec", "Wojciech");
            wojowniks[9] = Garnizon.TrainWarrior("strzelec", "Tadeusz");

            foreach (Wojownik woj in wojowniks) 
            {
                woj.ShowWeapon();
            }
        }
    }
}