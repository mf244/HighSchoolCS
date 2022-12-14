using System;

namespace MFEX40_Validate
{
    class MFEX40_Validate
    {
        
    
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}\n", anm, pnm, cdt, prp);       
}

public static void End()
{
            
    
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}

        
        static void Main()
        {
           #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX40_Validate";
const string CREATION_DATE = "3/15/22";
const string PURPOSE = "Learn loomps and recursion at same time";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion

            int intput = GetInt("number between 10 and 50"); 

            while (intput <10 || intput > 50) //The logic made sense once I coded it
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not within the ACCEPTABLE range. Try again."); //I spelled it right
                Console.ForegroundColor = ConsoleColor.White;
                intput = GetInt("number between 10 and 50");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank you!");
            Console.ForegroundColor = ConsoleColor.White;
            
            End();
        }

        public static int GetInt(string temp) // I used the method for the fancy color
        {
            Console.Write("Please enter {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            int tmpput = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            return tmpput;
        }
    }
}

/*
 * Create a Console Application called Ex40_Validate
(5 points) - Write a program that contains a loop to be used for input validation.  Valid entries are between 10 and 50 inclusive, that is includes the 10 and 50.  Test your program with values both less than and greater than the acceptable range.

You programs output should look similar to this:
*/