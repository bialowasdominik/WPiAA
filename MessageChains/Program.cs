namespace MessageChains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            string cylinderSize = car.GetCylinder(); 
            Console.WriteLine($"Cylider size: {cylinderSize}");
        }
    }
    public class Car
    {
        private readonly Engine _engine = new();

        public Engine GetEngine()
        {   
            return _engine;
        }

        public string GetCylinder() 
        {
            return _engine.GetCylinder().GetSize();
        }
    }

    public class Engine
    {
        public Cylinder GetCylinder()
        {
            return new Cylinder();
        }
    }

    public class Cylinder
    {
        public string GetSize()
        {
            return "2.0L";
        }
    }
}