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

    public UniversityStudent CheckUniversityStudent(UniversityStudent CheckInfo)
    {
        foreach(UniversityStudent person in this.personList)
        { 
            string prefix = CheckInfo.GetPrefix();
            string name = CheckInfo.GetName();
            string surname = CheckInfo.GetSurname();

            if (person.GetPrefix().Equals(prefix) && person.GetName().Equals(name) && person.GetSurname().Equals(surname))
            {
                return person;
            }
        }
        return null;
    }
    public HighSchoolStudent CheckHighSchoolStudent(HighSchoolStudent CheckInfo)
    {
        foreach(HighSchoolStudent person in this.personList)
        { 
            string prefix = CheckInfo.GetPrefix();
            string name = CheckInfo.GetName();
            string surname = CheckInfo.GetSurname();

            if (person.GetPrefix().Equals(prefix) && person.GetName().Equals(name) && person.GetSurname().Equals(surname))
            {
                return null;
            }
        }
        return CheckInfo;
    }
    public Teacher CheckTeacher(Teacher CheckInfo)
    {
        foreach(Teacher person in this.personList)
        { 
            string prefix = CheckInfo.GetPrefix();
            string name = CheckInfo.GetName();
            string surname = CheckInfo.GetSurname();

            if (person.GetPrefix().Equals(prefix) && person.GetName().Equals(name) && person.GetSurname().Equals(surname))
            {
                return person;
            }
        }
        return null;
    }
}