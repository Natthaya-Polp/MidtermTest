public class Teacher: Person
{
    private string position;
    private string carnum;
    private bool admin;
    private string email;
    private string password;

    public Teacher(string prefix, string name, string surname, string age, string position, string allergy, string religion, string carnum, bool admin, string email, string password)
    : base(prefix, name, surname, age, allergy, religion)
    {
        this.position = position;
        this.carnum = carnum;
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