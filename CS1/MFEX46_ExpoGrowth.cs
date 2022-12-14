/*
(10 points) - Write a program to determine what the population will be in Davidville in five years, ten years, 
??? years.  Projections for the city's growth indicate that for the next ??? years, there will be a constant 
increase of 4%.  Allow the user to enter the current  population of Davidville and how many years to expand out this 
projection.  Display a table with the growth expectations for the next ??? years.  You will need to think about and use 
the appropriate variable types to correctly display the population. In other words, you can't have a fraction of a person.  
Allow the user to re-run the program without quitting out of it. 
 */
using System;

namespace MFEX46_ExpoGrowth
{
    class MFEX46_ExpoGrowth
    {
        public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
}
        public static void End()
{
            
    
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}
        
        public static bool DoMore()
        {
            Console.Write("Would you like to run again? (y/n): ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string again = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            bool boolie = false;
            if (again == "y") 
            {
                boolie = true;
            }

            return boolie;
            
        }
        
        static void Main()
        {
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX46_ExpoGrowth";
const string CREATION_DATE = "3/29/22";
const string PURPOSE = "To learn looping with math";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            bool doMore = false;
            do
            {
                Console.WriteLine();
                double ppl = GetInt("people");
                int yrs = GetInt("years");

                Console.WriteLine("Year\tPopulation");//You said we can do it all in the main method
                Console.WriteLine("0\t{0}", ppl);

                for (int i = 1; i <= yrs; i++) //Always forget <=
                {
                    ppl = (0.04 * ppl) + ppl;//This took me an unholy amount of time to figure out
                    Console.WriteLine(i + "\t" + (int)ppl);
                }

                doMore = DoMore();
            } while (doMore);
            
            End();
        }

        public static int GetInt(string temp)
{
            Console.Write("Please enter the number of {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int intput = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            return intput;
}
    }
}
