using System;

namespace MFEX35_CircleArea
{
    class MFEX35_CircleArea
    {
        
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
}

        
public static void End()
{
            
    
    Console.WriteLine("\n-----Please press any key to end-----");
    Console.ReadKey();
}

        
        
        
        static void Main()
        {
           #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX35_CircleArea";
const string CREATION_DATE = "3/1/22";
const string PURPOSE = "To learn state controlled while loops.";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            
            bool moreData = true;
            do
            {
                double radius = GetDouble("the radius of the circle");

                double area = Calculate(radius);

                Display(radius, area);


                moreData = DoMore(); //Not sure if I should just do this in main in the future? Easy to copy in next time :)
            } while (moreData); //Plz dont yell at me for fake main method you told me to use methods
           


            

            End();
        }

        public static bool DoMore()
        {
            Console.Write("Would you like to run again? (y/n): ");
            Console.ForegroundColor = ConsoleColor.Red;
            string again = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            bool boolie = false;
            if (again == "y") //This was really satisfying to figure out
            {
                boolie = true;
            }

            return boolie;
            
        }
        
        public static double Calculate(double r) 
        {
            return Math.PI * Math.Pow(r, 2);

        }

        public static double GetDouble(string temp) 
        {
            Console.Write("\nPlease enter {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            double var = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            return var;
        }

        public static void Display(double r, double a)
        {
            Console.Write("The area of a circle with a radius of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(r);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" has an area of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0:N2}", a);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");
        }


    }
}
