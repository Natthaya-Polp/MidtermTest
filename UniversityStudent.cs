public class UniversityStudent: Person
{
    private string studentID;
    private bool admin;
    private string email;
    private string password;

    public UniversityStudent(string prefix, string name, string surname, string studentID, string age, string allergy, string religion, bool admin, string email, string password)
    : base(prefix, name, surname, age, allergy, religion)
    {
        this.studentID = studentID;
        this.admin = admin;
        this.email = email;
        this.password = password;
    }

    public string GetEmail()
    {
        return this.email;
    }

    public string GetPassword()
    {
        return this.password;
    }
}