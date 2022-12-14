using System;

namespace MFEX20_House
{
    class MFEX20_House
    {
        static void Main()
        {
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX20_House";
            const string CREATION_DATE = "12/6/21";
            const string PURPOSE = "To learn user input and math in methods";
            const int WINDOW_WIDTH = 120;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            double inLength = GetDoubles("length"); //These variable names are fine chill
            double inWidth = GetDoubles("width");
            double area = DoMath(inLength, inWidth);
            DisplayResults(inLength, inWidth, area); //Forgot to overload area here
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
        public static double GetDoubles(string temp)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is the {0} of the house?", temp);
            Console.ForegroundColor = ConsoleColor.Black; //Took me a second to figure this whole section out
            string input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        public static double DoMath(double L, double W)
        {
            return L * W;
        }

        public static void DisplayResults(double L, double W, double A)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("The area of a house with a length of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(L);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ft. and a width of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(W);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ft. would be ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(A);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" square feet.");
        }

        public static void Ending()
        {            
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }
    }
}
