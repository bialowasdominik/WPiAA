namespace RefusedBequest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IEmployee 
    {
        void Work();
        void AttendMeeting();
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public void Work() { Console.WriteLine("Working"); }
        public void AttendMeeting() { Console.WriteLine("Attending meeting"); }
    }

    public class Manager : Employee
    {
        public void ManageTeam() { Console.WriteLine("Managing team"); }
    }
}