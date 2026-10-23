namespace Core;

public class Person(
    string firstName,
    string lastName,
    string telephoneNumber,
    string personalNumber,
    Address address)
{
    public string Firstname { get; set; } = firstName;
    public string Lastname { get; set; } = lastName;
    public string TelephoneNumber { get; set; } = telephoneNumber;
    public string Personalnumber { get; set; } = personalNumber;
    public Address Address { get; set; } = address;
}





