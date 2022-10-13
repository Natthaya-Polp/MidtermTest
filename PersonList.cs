using System.Collections.Generic;
using System;
class PersonList
{
    private List<Person> personList;

    public PersonList()
    {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
    }

    public void FetchUniversityStudentList()
    {
        Console.WriteLine("List Current University Student");
        Console.WriteLine("-------------------------------");

        foreach(Person person in this.personList)
        {
            if (person is UniversityStudent)
            {
                Console.WriteLine("{0} {1} {2}", person.GetPrefix(), person.GetName(), person.GetSurname());
            }
        }
    }

    public void FetchHighSchoolStudentList()
    {
        Console.WriteLine("List High School Student");
        Console.WriteLine("------------------------");

        foreach(Person person in this.personList)
        {
            if (person is HighSchoolStudent)
            {
                Console.WriteLine("{0} {1} {2}", person.GetPrefix(), person.GetName(), person.GetSurname());
            }
        }
    }

    public void FetchTeacherList()
    {
        Console.WriteLine("List Teacher");
        Console.WriteLine("------------");

        foreach(Person person in this.personList)
        {
            if (person is Teacher)
            {
                Console.WriteLine("{0} {1} {2}", person.GetPrefix(), person.GetName(), person.GetSurname());
            }
        }
    }

    public void CountTeacher()
    {
        int count = 0;

        foreach(Person person in this.personList)
        {
            if (person is Teacher)
            {
                count++;
            }
        }
        Console.WriteLine("Total number of registered teachers : {0}",count);
    }

    public void CountHighSchoolStudent()
    {
        int count = 0;

        foreach(Person person in this.personList)
        {
            if (person is HighSchoolStudent)
            {
                count++;
            }
        }
        Console.WriteLine("Total number of registered high school students : {0}",count);
    }

    public void CountUniversityStudent()
    {
        int count = 0;

        foreach(Person person in this.personList)
        {
            if (person is UniversityStudent)
            {
                count++;
            }
        }
        Console.WriteLine("Total number of registered university students : {0}",count);
    }

    public void CountStudentGrade10()
    {
        int count = 0;
        foreach(Person person in personList)
        { 
            if (person is HighSchoolStudent highschoolstudent)
            {
                string grade = "10";
                if (highschoolstudent.GetGrade().Equals(grade))
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Total number of registered grade 10 students : {0}",count);
    }

    public void CountStudentGrade11()
    {
        int count = 0;
        foreach(Person person in personList)
        { 
            if (person is HighSchoolStudent highschoolstudent)
            {
                string grade = "11";
                if (highschoolstudent.GetGrade().Equals(grade))
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Total number of registered grade 11 students : {0}",count);
    }

    public void CountStudentGrade12()
    {
        int count = 0;
        foreach(Person person in personList)
        { 
            if (person is HighSchoolStudent highschoolstudent)
            {
                string grade = "12";
                if (highschoolstudent.GetGrade().Equals(grade))
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Total number of registered grade 12 students : {0}",count);
    }

    public UniversityStudent CheckUniversityStudent(UniversityStudent CheckUS)
    {
        if(personList is UniversityStudent)
        {
            foreach(UniversityStudent universitystudent in this.personList)
            { 
                string prefix = CheckUS.GetPrefix();
                string name = CheckUS.GetName();
                string surname = CheckUS.GetSurname();

                if (universitystudent.GetPrefix().Equals(prefix) && universitystudent.GetName().Equals(name) && universitystudent.GetSurname().Equals(surname))
                {
                    return null;
                }
            }
        }
        return CheckUS;
    }
    public HighSchoolStudent CheckHighSchoolStudent(HighSchoolStudent CheckHS)
    {
        if(personList is HighSchoolStudent)
        {
            foreach(HighSchoolStudent highschoolstudent in this.personList)
            { 
                string prefix = CheckHS.GetPrefix();
                string name = CheckHS.GetName();
                string surname = CheckHS.GetSurname();

                if (highschoolstudent.GetPrefix().Equals(prefix) && highschoolstudent.GetName().Equals(name) && highschoolstudent.GetSurname().Equals(surname))
                {
                    return null;
                }
            }
        }
        return CheckHS;
    }
    public Teacher CheckTeacher(Teacher CheckT)
    {
        if(personList is Teacher)
        {
            foreach(Teacher teacher in this.personList)
            { 
                string prefix = CheckT.GetPrefix();
                string name = CheckT.GetName();
                string surname = CheckT.GetSurname();

                if (teacher.GetPrefix().Equals(prefix) && teacher.GetName().Equals(name) && teacher.GetSurname().Equals(surname))
                {
                    return null;
                }
            }
        }
        return CheckT;
    }
}