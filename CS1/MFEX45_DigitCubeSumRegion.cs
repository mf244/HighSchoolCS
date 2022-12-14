using System;

namespace MFEX45_DigitCubeSumRegion
{
    class MFEX45_DigitCubeSumRegion
    {
      public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}\n", anm, pnm, cdt, prp);       
}

        public static void End()
{
            
    
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}
        
        
        public static bool DoMore()
        {
            Console.Write("Would you like to run again? (y/n): ");
            Console.ForegroundColor = ConsoleColor.Red;
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
const string PROGRAM_NAME = "MFEX45_DigitCubeSumRegion";
const string CREATION_DATE = "3/27/22";
const string PURPOSE = "To combine all of our previous knowledge to make something cool";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            bool doMore = false;
            do
            {
                for (int i = 10; i <= 1000; i++) //I love me a good loomp
                {
                    double calculated = CalculateDigits(i);
                    if (i == calculated)
                    {
                        Console.WriteLine(i + " is equal to its cube sum.");
                    }
                }

                doMore = DoMore();
            } while (doMore);
            
            
           End();


        }

        public static double FindCube(long digit, double cube) //Dont know if you wanted me to add this to the method or not
        {
            return Math.Pow(digit, 3) + cube; 
        }

        public static double CalculateDigits(long inputtedLong)
        {
            
            double cube = 0;
            long maxLong = 1000000000000000000;
            
            while (maxLong > inputtedLong)
            {
                maxLong /= 10;
            }
            while (inputtedLong != 0)
            {
                long digit = inputtedLong / maxLong;
                inputtedLong = inputtedLong % maxLong;
                

                
                cube = FindCube(digit, cube);
               


                maxLong /= 10;

            }

            return cube; //Added this return to make everything work nicely
            
        }
    }
}
