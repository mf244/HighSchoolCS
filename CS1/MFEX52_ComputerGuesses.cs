using System;

namespace MFEX52_ComputerGuesses
{
    class MFEX52_ComputerGuesses
    {
        #region consolecrap
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
            if (again == "y") //This was really satisfying to figure out
            {
                boolie = true;
            }

            return boolie;
            
        }

        #endregion
        
        
        public static int GetInt(string temp)
{
            Console.Write("\nPlease enter your {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if (num < 1 || num > 100)
            {
                num = GetInt("secret number BETWEEN 1 AND 100 INCLUSIVE");
            }

            return num;
            
}
        static void Main()
        {
           #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX52_ComputerGuesses";
const string CREATION_DATE = "4/29/22";
const string PURPOSE = "To learn looping and if statements";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion

            bool doMore = false;
            do
            {
                int num = GetInt("secret number between 1 and 100 inclusive");
                int highest = 100;
                int lowest = 1;
                int guesses = 0;
                int current = 0;
                string direction = "";

                do
                {
                    Random randy = new Random();
                    current = randy.Next((lowest), (highest + 1)); //The random class does "between num and num2-1 (inclusive)", so I added the +1 to adjust for that
                    Console.Write("My guess is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(current);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(". Is your number lower, higher, or the same (l/h/s)?: ");

                    direction = Console.ReadLine();
                    guesses++;
                    if (direction == "l")
                    {
                        highest = current-1; //I was getting duplicate numbers, but realised its because I was leaving the option it guessed as a possibility. Fixed by subtracting 1 from the guess before assigning
                    }
                    else if (direction == "h")
                    {
                        lowest = current+1; //I had the same problem here, but fixed it by doing the opposite as it's lowest number
                    }
                    else if (direction == "s")
                    {
                        Console.WriteLine("I guessed your number correctly! It took me {0} tries!", guesses);
                    }
                    
                } while (direction != "s"); //This is the best recursion for the loop I could think of without actually checking the inputted number against the guessed
  

                doMore = DoMore();
            } while (doMore);


            End();
        }
    }
}

/*
Create a console or windows application called EX52_ComputerGuesses.  Write code that plays a guessing game where the computer
tries to guess a number picked by the user.  The program asks the user to think of a secret number, and then asks the user a
sequence of guesses.  After each guess, the user must report whether it is too high or too low or correct.  The computer 
should be able to guess in the most efficient way(7 or less times for numbers between 1 and 100)The program should count the guesses.
(Hint: maintain highestPossible and lowestPossible variables, and always guess midway between the two.  This is called a binary search.) 
 */