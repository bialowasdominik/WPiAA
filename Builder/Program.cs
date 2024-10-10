namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garnizon garnizon = new Garnizon();

            WarriorBuilder piechurBuilder = new PiechurBuilder();
            WarriorBuilder strzelecBuilder = new StrzelecBuilder();
            WarriorBuilder konnyBuilder = new KonnyBuilder();

            List<IWarrior> armia = new List<IWarrior>();

            for (int i = 0; i < 2; i++) 
            {
                garnizon.SzkolWojownika(piechurBuilder);
                armia.Add(piechurBuilder.GetWarrior());

                garnizon.SzkolWojownika(strzelecBuilder);
                armia.Add(strzelecBuilder.GetWarrior());

                garnizon.SzkolWojownika(konnyBuilder);
                armia.Add(konnyBuilder.GetWarrior());
            }

            armia.ForEach(w => { w.Attack(); });
        }
    }
}