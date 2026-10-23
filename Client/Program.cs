namespace Client;
using Core;

class Program
{
static void Main()
{
        Course course = new(
        "C001",
        "Programmering i C#",
        10,
        new DateOnly(2026, 11, 1),
        new DateOnly(2027, 1, 10),
        true
    );

Address studentAddress = new("Gata 2", "553 00", "Jönköping");
    Student student = new(
        "Anders",
        "Andersson",
        "1235023983",
        "000000-0000",
        studentAddress
    );

    List<Course> courses = [course];
    List<Student> students = [student];
    List<Teacher> teachers = [];

    Address teacherAddress = new("Gata 3", "123 44", "Borås");
    Teacher teacher = new
    (
        "Bertil",
        "Lärare",
        "12309834093",
        "000000-1234",
        teacherAddress,   
        "Kemi",
        courses
    );
    teachers.Add(teacher);

    Console.WriteLine("WestCoast Education Internt System");

    while (true)
        {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1: Visa aktuella kurser");
        Console.WriteLine("2: Visa Studenter");
        Console.WriteLine("3: Lägg till Kurs");
        Console.WriteLine("4: Lägg till Student");
        Console.WriteLine("5: Visa Lärare");
        Console.WriteLine("x: Avsluta program");
        Console.WriteLine("--------------------------------");

            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    foreach (Course item in courses)
                    {
                        Console.WriteLine(item.Getinfo());
                    }
                break;
                case "2":
                    foreach (Student item in students)
                    {
                        Console.WriteLine(item.Getinfo());
                    }
                break;
                case "3":
                    Console.Write("Kursnummer: ");
                    string courseNumber = Console.ReadLine() ?? "";
                    Console.Write("Kursnamn: ");
                    string title = Console.ReadLine() ?? "";
                    Console.Write("Kursens Längd (Veckor): ");
                    int length = int.Parse(Console.ReadLine() ?? "");
                    Console.Write("Kursens startdatum (ÅÅÅÅ-MM-DD): ");
                    DateOnly startDate = DateOnly.Parse(Console.ReadLine() ?? "");
                    Console.Write("Kursens slutdatum (ÅÅÅÅ-MM-DD): ");
                    DateOnly endDate = DateOnly.Parse(Console.ReadLine() ?? "");
                    Console.Write("Är kursen på plats? (Ja/Nej): ");
                    string answer = Console.ReadLine() ?? "";

                    bool onsite;
                    if (answer.ToLower() == "ja")
                    {
                        onsite = true;
                    }
                    else
                    {
                        onsite = false;
                    }
                    Course newCourse = new                
                (
                    courseNumber,
                    title,
                    length,
                    startDate,
                    endDate,
                    onsite
                );
                    courses.Add(newCourse);
                
                break;
                case "4":
                    Console.Write("Förnamn: " );
                    string firstName = Console.ReadLine() ?? "";
                    Console.Write("Efternamn: " );
                    string lastName = Console.ReadLine() ?? "";
                    Console.Write("Telefonnummer: " );
                    string telephoneNumber = Console.ReadLine() ?? "";
                    Console.Write("Personnummer (ÅÅ-MM-DD-XXX): " );
                    string personalNumber = Console.ReadLine() ?? "";
                    Console.Write("Adress: " );
                    string address = Console.ReadLine() ?? "";
                    Console.Write("Postkod: " );
                    string postCode = Console.ReadLine() ?? "";
                    Console.Write("Ort: " );
                    string city = Console.ReadLine() ?? "";

                    Address newAddress = new(address, postCode, city);
                    Student newStudent = new                
                (
                    firstName,
                    lastName,
                    telephoneNumber,
                    personalNumber,
                    newAddress
                );

                    students.Add(newStudent);
                break;
                case "5":
                foreach (Teacher item in teachers)
                    {
                        Console.WriteLine(item.Getinfo());
                    }
                break;
                case "x":
                    return;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                break;
            }
        }
}
}
