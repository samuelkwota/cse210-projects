class Program
{
    static void Main()
    {
        // Creating instances of Address
        Address address1 = new Address("123 Main St", "Cityville", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Townsville", "NY", "67890");
        Address address3 = new Address("789 Oak St", "Villagetown", "TX", "54321");

        // Creating events of different types
        Lecture lectureEvent = new Lecture("Machine Learning", "Learn about AI", "2023-10-25", "14:00", address1, "Samuel Kwota", 30);
        Reception receptionEvent = new Reception("Networking", "Meet professionals", "31-10-2023", "18:00", address2, "samuelkwota.sk@gmail.com");
        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Picnic in the Park", "Family fun day", "06-11-2023", "12:00", address3, "Sunny and 75°F");

        // Generating and displaying marketing messages
        Console.WriteLine("Lecture Event:");
        Console.WriteLine("\n--- Standard Details ---");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine("\n--- Standard Details ---");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine("\n--- Standard Details ---");
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
    }
}