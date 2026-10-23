namespace Core;

public class Administrator(
    string firstName,
    string lastName,
    string telephoneNumber,
    string personalNumber,
    Address address,
    string subjects,
    List<Course> courses,
    DateOnly employmentDate) : EducationManagers(
        firstName,
        lastName,
        telephoneNumber,
        personalNumber,
        address,
        subjects,
        courses,
        employmentDate)
{
}