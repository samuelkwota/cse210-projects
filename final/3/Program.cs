using System;

class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }

    public Address(string street, string city, string state)
    {
        Street = street;
        City = city;
        State = state;
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}";
    }
}

class Event
{
    private string Title { get; set; }
    private string Description { get; set; }
    private DateTime Date { get; set; }
    private string Time { get; set; }
    private Address EventAddress { get; set; }

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress.GetFullAddress()}";
    }

    public string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Event Type: Generic\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

class Lecture : Event
{
    private string Speaker { get; set; }
    private int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

class Reception : Event
{
    private string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEvent Type: Reception\nRSVP Email: {RsvpEmail}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

class OutdoorGathering : Event
{
    private string WeatherStatement { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        WeatherStatement = weatherStatement;
    }

    public string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEvent Type: Outdoor Gathering\nWeather: {WeatherStatement}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Cityville", "CA");
        Address address2 = new Address("456 Elm St", "Townsville", "ON");

        Event genericEvent = new Event("Generic Event", "A sample event", DateTime.Now, "10:00 AM", address1);
        Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech discussion", DateTime.Now, "2:00 PM", address2, "John Smith", 50);
        Reception receptionEvent = new Reception("Holiday Party", "Celebrate with us", DateTime.Now, "7:00 PM", address1, "rsvp@example.com");
        OutdoorGathering gatheringEvent = new OutdoorGathering("Picnic", "Fun in the park", DateTime.Now, "12:00 PM", address2, "Sunny skies expected");

        Console.WriteLine("Generic Event - Standard Details:");
        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Lecture Event - Full Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Reception Event - Short Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event - Full Details:");
        Console.WriteLine(gatheringEvent.GetFullDetails());
    }
}