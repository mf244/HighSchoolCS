using System;

namespace MFEX23_HousePart3
{
    class MFEX23_HousePart3
    {
        static void Main()
        {
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX23_HousePart3";
            const string CREATION_DATE = "12/14/21";
            const string PURPOSE = "Get the conversion between yards and feet";
            const int WINDOW_WIDTH = 120;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            const int SQFT_IN_SQYD = 9;
            double inLength = GetDoubles("length"); 
            double inWidth = GetDoubles("width");
            double area = DoMath(inLength, inWidth);
            double yards = SqFeetToSqYards(area, SQFT_IN_SQYD);
            DisplayResults(inLength, inWidth, area, yards); //Almost forgot to add to this
            Ending();
        }

        public static double SqFeetToSqYards(double a, double cont)
        {
            return a / cont;
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
            Console.Write("What is the {0} of the house? ", temp);
            Console.ForegroundColor = ConsoleColor.Black; 
            string input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        public static double DoMath(double L, double W)
        {
            return L * W;
        }

        public static void DisplayResults(double L, double W, double A, double Y)
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
            Console.Write("The square yards would be: ");//Kept with the color scheme
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0:N2}", Y); //Format specifier!

        }

        public static void Ending()
        {
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }
    }
}
