namespace Core;

public class EducationManagers(
    string firstName,
    string lastName,
    string telephoneNumber,
    string personalNumber,
    Address address,
    string subjects,
    List<Course> courses,
    DateOnly employmentDate) : Teacher(
        firstName,
        lastName,
        telephoneNumber,
        personalNumber,
        address,
        subjects,
        courses)
{
    public DateOnly EmploymentDate { get; set; } = employmentDate;
}