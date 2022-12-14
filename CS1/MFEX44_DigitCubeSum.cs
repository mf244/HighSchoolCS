using System;

namespace MFEX44_DigitCubeSum
{
    class MFEX44_DigitCubeSum
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
            const string PROGRAM_NAME = "MFEX44_DigitCubeSum";
            const string CREATION_DATE = "3/27/22";
            const string PURPOSE = "To add cubes and recursion";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion

            bool doMore = false;
            do
            {
                
                long inputtedLong = AskUserForLong("long");
                CalculateDigits(inputtedLong); 

                doMore = DoMore();
            } while (doMore);

            End();
        }

       
        public static long AskUserForLong(string tmp) //Yaay new method
        {
            Console.Write("Please enter your {0}: ", tmp);
            long num = Convert.ToInt64(Console.ReadLine()); 
            if (num <= 0)
            {
                Console.WriteLine("Invalid input. Please input a positive number");
                num = AskUserForLong("valid long");
            }

            return num;
        }
        
        public static void CalculateDigits(long inputtedLong)
        {
            long sum = 0; 
            double cube = 0;
            long maxLong = 1000000000000000000;
            //long savedLong = inputtedLong;
            while (maxLong > inputtedLong)
            {
                maxLong /= 10;
            }
            while (inputtedLong != 0)
            {
                long digit = inputtedLong / maxLong;
                inputtedLong = inputtedLong % maxLong;
                Console.WriteLine(digit);

                sum = FindSum(digit, sum); 
                cube = FindCube(digit, cube);//This method of incrementing is intersting
                /*
                if (savedLong == cube)
                {
                   Console.WriteLine("the original number is equal to the sum of cubes!");
                }

                */
                maxLong /= 10;

            }

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The cube sum is: " + cube); //Display the cube
        }


        public static long FindSum(long digit, long sum)
        {
            return digit + sum;
        }

        

      public static double FindCube(long digit, double cube)
       {
           return Math.Pow(digit, 3) + cube; //No casting needed because I bring in cube as a double
       }

       
    }
}
