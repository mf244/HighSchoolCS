using System;

namespace MFEX43_DigitSum
{
    class MFEX43_DigitSum
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
            const string PROGRAM_NAME = "MFEX43_DigitSum";
            const string CREATION_DATE = "3/27/22";
            const string PURPOSE = "To learn adding from loops in methods";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion

            bool doMore = false;
            do
            {
                Console.Write("Please enter your num: "); 
                long inputtedLong = Convert.ToInt64(Console.ReadLine());
                CalculateDigits(inputtedLong);

                doMore = DoMore();
            } while (doMore);

            End();
        }

        public static void CalculateDigits(long inputtedLong)
        {
            long sum = 0; //Initialize out here to use outside loop
            //double cube = 0;
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

                sum = FindSum(digit, sum); //Call the method
                //cube = FindCube(digit, cube);
                //if (savedLong == cube)
                //{
                //    Console.WriteLine("the original number is equal to the sum of cubes!");
                //}


                maxLong /= 10;

            }

            Console.WriteLine("The sum is: " + sum);
            //Console.WriteLine("The cube is: " + cube);
        }

        
        public static long FindSum(long digit, long sum)
        {
            return digit + sum;//This is a really short method but you wanted it in a method so here ya go
        }

         /*

       public static double FindCube(long digit, double cube)
        {
            return Math.Pow(digit, 3) + cube;
        }

        */
    }
}
