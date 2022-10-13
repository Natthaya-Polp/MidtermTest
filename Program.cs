using System;

enum Menu
{
    Register = 1,
    ShowStat,
    SignIn
}

enum SignInMenu
{
    Register = 1,
    ShowUniversityStudent,
    ShowHighSchoolStudent,
    ShowTeacher,
    SignOut
}

enum RegisterMenu
{
    UniversityStudent = 1,
    HighSchoolStudent,
    Teacher
}

class Program
{
    static PersonList personList;
    static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenu();
    }

    static void PrintMenu()
    {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PrintListMenu()
    {
        Console.WriteLine("  Welcome to IdeaCamp Menu");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Show Exhibitors Statistics");
        Console.WriteLine("3. Sign In");
        Console.WriteLine("-----------------------------");
    }

    static void InputMenuFromKeyboard()
    {
        Console.Write("Please Input Menu ( 1 / 2 / 3 ) : ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }

    static void PresentMenu(Menu menu)
    {
        switch (menu)
        {
            case Menu.Register:
                PrintListRegisterMenu();
                break;
            case Menu.ShowStat:
                ShowStat();
                break;
            case Menu.SignIn:
                InputSignInInfo();
                break;
            default:
                break;
        }
    }

    static void PrintListSignInMenu()
    {
        Console.Clear();
        Console.WriteLine("        Hello! Welcome to Main Menu");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Show Current University Student Information");
        Console.WriteLine("3. Show High School Student Information");
        Console.WriteLine("4. Show Teacher Information");
        Console.WriteLine("5. Sign Out");
        Console.WriteLine("----------------------------------------------");
        InputSignInMenuFromKeyboard();
    }

    static void InputSignInMenuFromKeyboard()
    {
        Console.Write("Please Input Menu ( 1 / 2 / 3 / 4 / 5 ) : ");
        SignInMenu signinmenu = (SignInMenu)(int.Parse(Console.ReadLine()));

        PresentSignInMenu(signinmenu);
    }

    static void PresentSignInMenu(SignInMenu signinmenu)
    {
        switch (signinmenu)
        {
            case SignInMenu.Register:
                PrintListRegisterMenu();
                break;
            case SignInMenu.ShowUniversityStudent:
                ShowUniversityStudentList();
                break;
            case SignInMenu.ShowHighSchoolStudent:
                ShowHighSchoolStudentList();
                break;
            case SignInMenu.ShowTeacher:
                ShowTeacherList();
                break;
            case SignInMenu.SignOut:
                BackToMainMenu();
                break;
            default:
                break;
        }
    }

    static void BackToMainMenu()
    {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void InputToBackToMenu()
    {
        Console.Write("Please input 'exit' to back to main menu : ");
        string exit = Console.ReadLine();
        if (exit == "exit")
        {
            BackToMainMenu();
        }
        else
        {
            BackToMainMenu();
        }
    }

    static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personList = new PersonList();
    }

    static void ShowUniversityStudentList()
    {
        Program.personList.FetchUniversityStudentList();
        InputToBackToMenu();
    }

    static void ShowHighSchoolStudentList()
    {
        Program.personList.FetchHighSchoolStudentList();
        InputToBackToMenu();
    }

    static void ShowTeacherList()
    {
        Program.personList.FetchTeacherList();
        InputToBackToMenu();
    }

    static void PrintListRegisterMenu()
    {
        Console.Clear();
        Console.WriteLine("Register Menu : What type are you?");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1. University Student");
        Console.WriteLine("2. High School Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("----------------------------------");
        InputRegisterMenuFromKeyboard();
    }

    static void InputRegisterMenuFromKeyboard()
    {
        Console.Write("Please Input Menu ( 1 / 2 / 3 ) : ");
        RegisterMenu registermenu = (RegisterMenu)(int.Parse(Console.ReadLine()));

        PresentRegisterMenu(registermenu);
    }

    static void PresentRegisterMenu(RegisterMenu registermenu)
    {
        switch (registermenu)
        {
            case RegisterMenu.UniversityStudent:
                InputNewUniversityStudent();
                break;
            case RegisterMenu.HighSchoolStudent:
                InputNewHighSchoolStudent();
                break;
            case RegisterMenu.Teacher:
                InputNewTeacher();
                break;
            default:
                break;
        }
    }

    static void InputNewUniversityStudent()
    {
        Console.Clear();
        bool admincheck;

        UniversityStudent universitystudent = new UniversityStudent
        (InputPrefix(),InputName(),InputSurname(),InputStudentID(),InputAge(),InputAllergy(),InputReligion(),
        admincheck = AreYouAnAdmin(),InputEmail(admincheck),InputPassword(admincheck));

        UniversityStudent check = personList.CheckUniversityStudent(universitystudent);
        if(check == null)
        {
            Program.personList.AddNewPerson(universitystudent);
            BackToMainMenu();
        }
        else
        {
            Console.Write("User is already registered. Please try again. ( Press Enter to continue. )");
            Console.ReadLine();
            InputNewUniversityStudent();
        }
    }

    static void InputNewHighSchoolStudent()
    {
        Console.Clear();

        HighSchoolStudent highschoolstudent = new HighSchoolStudent
        (InputPrefix(),InputName(),InputSurname(),InputAge(),InputGrade(),InputAllergy(),InputReligion(),InputSchoolName());

        HighSchoolStudent check = personList.CheckHighSchoolStudent(highschoolstudent);
        if(check != null)
        {
            Program.personList.AddNewPerson(highschoolstudent);
            BackToMainMenu();
        }
        else
        {
            Console.Write("User is already registered. Please try again. ( Press Enter to continue. )");
            Console.ReadLine();
            InputNewHighSchoolStudent();
        }
    }

    static void InputNewTeacher()
    {
        Console.Clear();
        bool admincheck;

        Teacher teacher = new Teacher
        (InputPrefix(),InputName(),InputSurname(),InputAge(),InputPosition(),InputAllergy(),InputReligion(),InputCarNumber(),
        admincheck = AreYouAnAdmin(),InputEmail(admincheck),InputPassword(admincheck));

        Teacher check = personList.CheckTeacher(teacher);
        if(check == null)
        {
            Program.personList.AddNewPerson(teacher);
            BackToMainMenu();
        }
        else
        {
            Console.Write("User is already registered. Please try again. ( Press Enter to continue. )");
            Console.ReadLine();
            InputNewTeacher();
        }
    }

    static string InputPrefix()
    {
        Console.Write("Name Prefix ( Mr. / Mrs. / Miss ) : ");
        return Console.ReadLine();
    }

    static string InputName()
    {
        Console.Write("Name : ");

        return Console.ReadLine();
    }

    static string InputSurname()
    {
        Console.Write("Surname : ");

        return Console.ReadLine();
    }

    static string InputStudentID()
    {
        Console.Write("StudentID : ");

        return Console.ReadLine();
    }

    static string InputAge()
    {
        Console.Write("Age : ");

        return Console.ReadLine();
    }

    static string InputAllergy()
    {
        Console.Write("Allergy : ");

        return Console.ReadLine();
    }

    static string InputReligion()
    {
        Console.Write("Religion ( Buddhism / Christianity / Islam / Other ) : ");
        return Console.ReadLine();
    }

    static string InputGrade()
    {
        Console.Write("Grade ( 10 / 11 / 12 ) : ");
        return Console.ReadLine();
    }

    static string InputSchoolName()
    {
        Console.Write("School Name : ");

        return Console.ReadLine();
    }

    static string InputPosition()
    {
        Console.Write("Position ( Dean / Head of Department / Teacher ) : ");
        return Console.ReadLine();
    }

    static string InputCarNumber()
    {
        Console.Write("Did you bring your car here? ( y / n ) : ");
        char ans = char.Parse(Console.ReadLine());
        
        if ( ans == 'y' )
        {
            Console.Write("What is your car number? : ");
            return Console.ReadLine();
        }
        else
        {
            return "";
        }
    }

    static bool AreYouAnAdmin()
    {
        Console.Write("Are you an administrator? ( y / n ) : ");
        char ans = char.Parse(Console.ReadLine());
        
        if ( ans == 'y' )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static string InputEmail(bool admincheck)
    {
        if (admincheck == true)
        {
            Console.Write("Email : ");
            return Console.ReadLine();
        }
        else
        {
            return "";
        }
    }

    static string InputPassword(bool admincheck)
    {
        if (admincheck == true)
        {
            Console.Write("Password : ");
            return Console.ReadLine();
        }
        else
        {
            return "";
        }
    }

    static void InputSignInInfo()
    {
        Console.WriteLine("                Sign In                 ");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Please input 'exit' to back to main menu");
        Console.Write("Email    : ");
        string email = Console.ReadLine();

        if (email == "exit")
        {
            BackToMainMenu();
        }
        else
        {
            Console.Write("Password : ");
            Console.ReadLine();
            PrintListSignInMenu();
        }
    }

    static void ShowStat()
    {
        Program.personList.CountTeacher();
        Program.personList.CountHighSchoolStudent();
        Program.personList.CountUniversityStudent();

        Console.Write("Press Enter to back to main menu.");
        Console.ReadLine();
        BackToMainMenu();
    }
}