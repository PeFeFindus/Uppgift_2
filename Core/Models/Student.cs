namespace Core;

public class Student(
    string firstName,
    string lastName,
    string telephoneNumber,
    string personalNumber,
    Address adress) : Person(firstName, lastName, telephoneNumber, personalNumber, adress)
{
    public string Getinfo()
    {
        return $"Förnamn: {Firstname}\nEfternamn: {Lastname}\nTelefonnummer: {TelephoneNumber}\nPersonnummer: {Personalnumber}\nAdress: {Address.Street}\nPostkod: {Address.PostCode}\nOrt: {Address.City}";
    }
}