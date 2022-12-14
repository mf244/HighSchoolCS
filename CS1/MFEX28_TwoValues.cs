using System;

namespace MFEX28_TwoValues
{
    class MFEX28_TwoValues
    {
        
        #region Start
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
}
#endregion
        #region end
public static void End()
{
            
    
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}
#endregion
        
        static void Main()
        {
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX28_TwoValues";
const string CREATION_DATE = "2/1/22";
const string PURPOSE = "To learn if else ladders and to expand our knowledge of coding";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            double valueOne = GetDoubles("first value");
            double valueTwo = GetDoubles("second value");
            
            FindSizes(valueOne, valueTwo); //I feel like this is not enough for my main method but it works

            End();
        }

        public static double GetDoubles(string tmp)
        {
            Console.Write("Please enter the {0}: ", tmp); 
            Console.ForegroundColor = ConsoleColor.Red; //I finally decided to use some color and make my programs look nicer. 
            double val = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White; //I was going to just return the readline but I needed to split it to change the color back
            return val;
        }

        public static void FindSizes(double valOne, double valTwo)
        {
            if (valOne > valTwo) //Min would be so much easier but I do as lord Lynch guides
            {
                Console.Write("The smallest value is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(valTwo);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (valOne < valTwo)
            {
                Console.Write("The smallest value is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(valOne);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (valOne == valTwo)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Great job knucklehead, both of those values are the same.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else //I'm not sure why this would be called, but it's good to make my code robust I guess?
            {

                Console.ForegroundColor = ConsoleColor.Red; //RED ERROR
                Console.WriteLine("What did you even do to get this message? How did you do this? Knucklehead.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
