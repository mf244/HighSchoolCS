using System;

namespace MFEX21_Operation
{
    class MFEX21_Operation
    {
        static void Main()
        {

            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX21_Operation";
            const string CREATION_DATE = "12/10/21";
            const string PURPOSE = "Learn modulo and division in methods"; 
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            int int1 = GetInts("first integer");
            int int2 = GetInts("second integer");
            int divFirst = GetDivision(int1, int2);
            int divSecond = GetDivision(int2, int1);//Made these lowercase just for you i fixed it
            int modFirst = GetModulo(int1, int2);
            int modSecond = GetModulo(int2, int1);
            DisplayResults(int1, int2, divFirst, divSecond, modFirst, modSecond);
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
        
        
        public static int GetInts(string temp)
        {
            Console.Write("Please enter the {0}:     ", temp);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static int GetDivision(int one, int two)
        {
            return one / two;
        }

        public static int GetModulo (int one, int two)
        {
            return one % two;
        }

        public static void DisplayResults(int one, int two, int divOne, int divTwo, int modOne, int modTwo )
        {
            Console.WriteLine("{0}/{1} = {2}", one, two, divOne);
            Console.WriteLine("{0}%{1} = {2}", one, two, modOne);//Greg did this a stupid way
            Console.WriteLine("{0}/{1} = {2}", two, one, divTwo);//I also went 0, 2, 3 here
            Console.WriteLine("{0}%{1} = {2}", two, one, modTwo);
        }



        public static void Ending()
        {
            
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }
    }
}
