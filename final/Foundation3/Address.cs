// Address class to store event addresses
class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Zipcode { get; private set; }

    public Address(string street, string city, string state, string zipcode)
    {
        Street = street;
        City = city;
        State = state;
        Zipcode = zipcode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {Zipcode}";
    }
}

