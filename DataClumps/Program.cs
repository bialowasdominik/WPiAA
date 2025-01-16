namespace DataClumps
{
    public class EventDetails
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }

        public EventDetails(string eventName, DateTime eventDate, string location)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
        }

        public void RegisterEvent()
        {
            Console.WriteLine($"Event: {EventName}, Date: {EventDate}, Location: {Location}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var eventDetails = new EventDetails("Tech Conference", new DateTime(2025, 5, 20), "New York");
            eventDetails.RegisterEvent();
        }
    }
}
