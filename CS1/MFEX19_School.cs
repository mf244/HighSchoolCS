using System;

namespace MFEX19_School
{
    class MFEX19_School
    {
        static void Main()
        {
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX19_School";
            const string CREATION_DATE = "12/3/21";
            const string PURPOSE = "Use static void methods";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);

            string schoolName = "Council Rock High School South";
            string studentsEnrolled = "2000";
            string schoolColors = "navy blue and white";
            string schoolAddress = "2002 Rock Way, Holland, PA 18966";
            string schoolPhone = "(215) 944-1100";
            string schoolPrincipal = "Albert R. Funk";
            string schoolGrades = "9, 10, 11, and 12";
            DisplayInfo(schoolName, studentsEnrolled, schoolColors, schoolAddress, schoolPhone, schoolPrincipal, schoolGrades);
            Ending();
        }

        public static void Intro(string anm, string pnm, string cdt, string prp, int w, int h)
        {
            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
        }

        public static void DisplayInfo(string name, string students, string colors, string address, string phone, string principal, string grades)
        {
            Console.WriteLine("\nHere is the info for {0}:", name); //Had to add newlines here
            Console.WriteLine("{0} has {1} students enrolled.", name, students);
            Console.WriteLine("{0}'s colors are {1}.", name, colors);
            Console.WriteLine("{0}'s mailing address is {1}.",name , address);
            Console.WriteLine("{0}'s phone number is {1}.", name, phone);
            Console.WriteLine("{0}'s principal is {1}.", name, principal);//Straight bracket here instead of curly
            Console.WriteLine("{0} serves grades {1}", name, grades); 
        }

        public static void Ending()
        {
            Console.WriteLine("\n\n\n\n-----Please press any key to end-----");//Had the newlines in wrong spot
            Console.ReadKey();
        }
    }
}
