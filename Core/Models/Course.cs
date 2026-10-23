namespace Core;

public class Course
{
    public string Coursenumber { get; set; }
    public string Title { get; set; }
    public int Length { get; set; }
    public DateOnly Startdate { get; set; }
    public DateOnly Enddate { get; set; }
    public bool Onsite { get; set; }

    public Course
    (
        string courseNumber, 
        string title, 
        int length, 
        DateOnly startdate,
        DateOnly enddate, 
        bool onsite
    )
    
    {
        if (startdate > enddate)
        {
            throw new ArgumentException("Kursens slutdatum är före startdatum");
        }
        Coursenumber = courseNumber;
        Title = title;
        Length = length;
        Startdate = startdate;
        Enddate = enddate;
        Onsite = onsite;
    }
    public string Getinfo()
    {
        string courseType;
        if (Onsite)
        {
            courseType = "Ja";
        }
        else
        {
            courseType = "Nej";
        }
        return $"Kursnummer: {Coursenumber}\nKursnamn: {Title}\nKursens längd (Veckor):{Length}\nStart: {Startdate}\nSlut: {Enddate}\nOrtsbunden: {courseType}";
    }
}

