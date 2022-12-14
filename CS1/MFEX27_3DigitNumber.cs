using System;

namespace MFEX27_3DigitNumber
{
    class MFEX27_3DigitNumber
    {
        
        #region Start
        public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
        {
      
            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
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
            const string PROGRAM_NAME = "EX27_3DigitNumber";
            const string CREATION_DATE = "1/24/22";
            const string PURPOSE = "To learn the uses of modulo and use ref and out.";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Console.ForegroundColor = ConsoleColor.White;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion
            
            int tdn = GetNumber("Enter a 3 digit number: ");

            int digit1, digit2, digit3; //make these here so they show up in method

            int sumOfDigits = GetSum(tdn, out digit1, out digit2, out digit3);

            Display(digit1, digit2, digit3, sumOfDigits);
            
            End();

        }

        public static int GetNumber(string reason)
        {
            

            Console.Write(reason);

            Console.ForegroundColor = ConsoleColor.Red;
            int input = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if (input > 999 || input < 100) //I know you don't like int parse but it works better
            {
                input = GetNumber("Invalid input. Try again: ");
            }
            
            
                return input;
            

        }

        public static int GetSum(int num, out int d1, out int d2, out int d3)
        {
            d1 = num / 100;
            d2 = num % 100 / 10;
            d3 = num % 100 % 10;

            return d1 + d2 + d3;
        }

        public static void Display(int d1, int d2, int d3, int sum)
        {
            Console.WriteLine("The digits are:\n{0}\n{1}\n{2}\nAnd the sum is: {3}",d1, d2, d3, sum);
            if (sum%2 == 0)
            {
                Console.WriteLine("That sum is even.");
            }
            else if (sum%2 == 1)
            {
                Console.WriteLine("That sum is odd.");
            }
            else //I know this probably won't happen but it's good to be robust
            {
                Console.WriteLine("Bruh.");
            }
        }
    }
}
