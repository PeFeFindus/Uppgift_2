namespace Core;

public class Address(string street, string postCode, string city)
{
    public string Street { get; set; } = street;
    public string PostCode { get; set; } = postCode;
    public string City { get; set; } = city;
}
