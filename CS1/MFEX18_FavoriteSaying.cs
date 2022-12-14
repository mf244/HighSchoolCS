using System;

namespace MFEX18_FavoriteSaying
{
    class MFEX18_FavoriteSaying
    {
        static void Main()
        {
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX18_FavoriteSaying";
            const string CREATION_DATE = "12/3/21";
            const string PURPOSE = "To use methods to get input and display output";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            string favSaying = GetSaying();
            DisplaySaying(favSaying);
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
        public static string GetSaying()
        {
            Console.Write("Please enter your favorite saying: ");
            return Console.ReadLine(); // Forgot to add two parenthese here and broke the whole thing
            //Oh yeah baby it works        
        }

        public static void DisplaySaying(string s)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("** {0}", s);
            Console.WriteLine("**********************************"); //I have no idea how to center this oh well
        }

        public static void Ending()
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }
    }
}
