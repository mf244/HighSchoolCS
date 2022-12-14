using System;

namespace MattFloydEx17Intro
{
    class MattFloydEx17Intro
    {
        static void Main()
        {
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX17_Intro";
            const string CREATION_DATE = "11/29/21";
            const string PURPOSE = "To show usage of intro and ending methods.";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45; //Took me forvever to figure out a good size
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);//Accidentaly had the whole public static part here
            Ending();
        }
        
        public static void Ending()
        {
            Console.SetCursorPosition(10, 10); //I did not have numbers in here the first time
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }
        public static void Intro(string anm, string pnm, string cdt, string prp, int w, int h)
        {
            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
        }
    }
}
