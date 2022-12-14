using System;

namespace MFEX22_Time
{
    class MFEX22_Time
    {
        static void Main()
        {
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX22_Time";
            const string CREATION_DATE = "12/10/21";
            const string PURPOSE = "To learn \"D\" format specifier"; //ESCAPE SEQUENCE!
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            const int MINUTES_IN_HOUR = 60;
            int minutes = CollectData();
            int finalHours = CalculateHours(minutes, MINUTES_IN_HOUR);
            int finalMinutes = CalculateMinutes(minutes, MINUTES_IN_HOUR);
            DisplayData(minutes, finalHours, finalMinutes); //Oop had an extra semicolon here
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
        public static int CollectData()
        {
            Console.Write("Please enter the number of minutes: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int CalculateHours(int mines, int cont) //tried to use const as var name here
        {
            return mines / cont; //Had a bunch of spelling mistakes here
        }

        public static int CalculateMinutes(int mines, int cont)
        {
            return mines % cont;
        }

        public static void DisplayData(int mins, int fHours, int fMins)
        {
            Console.WriteLine("{0} minutes translates to {1}:{2:D2}.", mins, fHours, fMins); //Needs to be D2 not D1
        }

        public static void Ending()
        {
            
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }

    }
}
