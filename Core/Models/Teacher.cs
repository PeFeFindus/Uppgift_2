namespace Core;

public class Teacher(
    string firstName,
    string lastName,
    string telephoneNumber,
    string personalNumber,
    Address address,
    string subjects,
    List<Course> courses) : Person(firstName, lastName, telephoneNumber, personalNumber, address)
{
    public string Subjects { get; set; } = subjects;
    public List<Course> Courses { get; set; } = courses;

    public string Getinfo()
    {
        string info = $"Förnamn: {Firstname}\nEfternamn: {Lastname}\nTelefonnummer: {TelephoneNumber}\nPersonnummer: {Personalnumber}\nAdress: {Address.Street}\nPostkod: {Address.PostCode}\nOrt: {Address.City}\nÄmnen: {Subjects}\nKurser:";

        if (Courses.Count == 0)
        {
            info += "\nInga kurser tilldelade.";
        }
        else
        {
            foreach (Course course in Courses)
            {
                info += $"\n- {course.Title}";
            }
        }

        return info;
    }
}