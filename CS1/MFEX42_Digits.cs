using System;

namespace MFEX42_Digits
{
    class MFEX42_Digits
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
            const string PROGRAM_NAME = "MFEX42_Digits";
            const string CREATION_DATE = "3/25/22";
            const string PURPOSE = "To learn looping and digits and complex maths";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion

            bool doMore = false;
            do
            {
                Console.Write("Please enter your num: "); //I did this outside the other method to make it not a fake MM
                long inputtedLong = Convert.ToInt64(Console.ReadLine());
                CalculateDigits(inputtedLong); //This becomes the display method

                doMore = DoMore();
            } while (doMore);
            
            End();
        }

        public static void CalculateDigits(long inputtedLong)
        {
            //long sum = 0;
            //double cube = 0;
            long maxLong = 1000000000000000000;
            //long savedLong = inputtedLong;
            while (maxLong > inputtedLong)
            {
                maxLong /= 10;
            }
            while (inputtedLong != 0)
            {
                long digit = inputtedLong / maxLong; //This took me a while to get right
                inputtedLong = inputtedLong % maxLong;
                Console.WriteLine(digit);

                //sum = FindSum(digit, sum);
                //cube = FindCube(digit, cube);
                //if (savedLong == cube)
                //{
                //    Console.WriteLine("the original number is equal to the sum of cubes!");
                //}


                maxLong /= 10;
                
            }

            //Console.WriteLine("The sum is: " + sum);
            //Console.WriteLine("The cube is: " + cube);
        }
        
        /*
        public static long FindSum(long digit, long sum)
        {
            return digit + sum;
        }

       public static double FindCube(long digit, double cube)
        {
            return Math.Pow(digit, 3) + cube;
        }

        */
    }
}
