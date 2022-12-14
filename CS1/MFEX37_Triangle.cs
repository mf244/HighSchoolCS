/*
 Create a Console Application called EX37_Triangle.  
(10 points) - Prompt the user for the length of three line segments as integers. If the three lines could form a triangle, 
print the integers and a message indicating they form a triangle. For this example make all of the side lengths integers. 
Recall that the sum of the length of any two sides must be greater than the length of the third side to form a triangle.  
For example, 20, 5, and 10 cannot be the length of the sides of a triangle because 5 + 10 is not greater than 20.  
For line segments that do not form a triangle, print the integers, and an appropriate message indicating no triangle can be created.  
Use a state-controlled loop (bool moreData = true;) to allow users to enter as many different combinations as they want.  
Indicate if the triangle is an equilateral triangle.

o    Using If…Else statements you have the flexibility to write the logic many different ways.
*/

using System;

namespace MFEX37_Triangle
{
    class MFEX37_Triangle
    {

public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
}

public static void End()
{
            
    
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}

        
        
        static void Main() //If you yell at me for using a fake main method ill be mad cause you told me to
        {
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX37_Triangle";
const string CREATION_DATE = "3/7/22";
const string PURPOSE = "To learn state controlled loops and complex ifs";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            bool moreData = false;
            do
            {
                Console.WriteLine("");
                double s1 = GetDouble("first side");
                double s2 = GetDouble("second side");
                double s3 = GetDouble("third side");

                CheckTriangle(s1, s2, s3);

                
                Console.Write("\nWould you like to run again? (y/n): "); //This works right? Don't want another way?
                if (Console.ReadLine().ToLower() == "y")
                {
                    moreData = true;
                }
                else
                {
                    moreData = false;
                    Console.WriteLine("Goodbye!");
                }
            } while (moreData);

            End();
                  
        }

        public static double GetDouble(string temp)
        {
            Console.Write("Please enter the {0}: ", temp);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void CheckTriangle(double s1, double s2, double s3) //This could have been a main method...
        {
            if (s1 + s2 > s3 && s2 + s3 > s3 && s1 + s3 > s2)
            {
                Console.WriteLine("\nA triangle with the side lengths of {0}, {1}, and {2} is possible.", s1, s2, s3);
                if (s1 == s2 && s1 == s3)
                {
                    Console.WriteLine("This triangle is also equilateral.");
                }

            }
            else
            {
                Console.WriteLine("This triangle is not possible.");
            }
        }
    }
}

