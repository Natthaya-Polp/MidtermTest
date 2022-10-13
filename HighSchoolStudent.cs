public class HighSchoolStudent: Person
{
    private string grade;
    private string schoolname;

    public HighSchoolStudent(string prefix, string name, string surname, string age, string grade, string allergy, string religion, string schoolname)
    : base(prefix, name, surname, age, allergy, religion)
    {
        this.grade = grade;
        this.schoolname = schoolname;
    }

    public string GetGrade()
    {
        return this.grade;
    }
}