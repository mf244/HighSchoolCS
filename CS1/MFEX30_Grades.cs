using System;

namespace MFEX30_Grades
{
    class MFEX30_Grades
    {
        
        #region Start
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkGray;
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
            const string PROGRAM_NAME = "EX30_Grades";
            const string CREATION_DATE = "2/3/22";
            const string PURPOSE = "To learn Math.Round in methods and to use if statements to find a letter grade\n";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion

            
            double scoreOne = GetScores("first score");
            double scoreTwo = GetScores("second score");
            double scoreThree = GetScores("third score");
            double scoreFour = GetScores("fourth score");
            double scoreFive = GetScores("fifth score");


            double preRound = FindAverage(scoreOne, scoreTwo, scoreThree, scoreFour, scoreFive);


            string letterGrade = FindLetter(preRound);


            DisplayResults(preRound, letterGrade, scoreOne, scoreTwo, scoreThree, scoreFour, scoreFive);

            End();
        }

        public static double GetScores(string temp)
        {
            Console.Write("Please enter your {0} as a percentage without a % symbol: ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            double score = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if (score < 0.00 || score > 100.00)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not a valid score knucklehead, try again."); //I still am not great at recursion, but this works
                Console.ForegroundColor = ConsoleColor.White;
                score = GetScores("score again");
            }
            return score;

        }

        public static double FindAverage(double one, double two, double three, double four, double five)//This method seems suspiciously simple...
        {
            
            return (one + two + three + four + five) / 5; //I tried to do an out of the pre-round, but I couldn't figure it out
        }

        public static string FindLetter(double avg)
        {
            string letter = "";

            if (avg <= 100.00 && avg >= 89.50)
            {
                letter = "A";
            }
            else if (avg <= 89.49 && avg >= 79.50) //Not sure if else if was correct here, but it works
            {
                letter = "B";
            }
            else if (avg <= 79.49 && avg >= 69.50)
            {
                letter = "C";
            }
            else if (avg <= 69.49 && avg >= 59.50)
            {
                letter = "D";
            }
            else if (avg <= 59.49 && avg >= 0.00 )
            {
                letter = "F";
            }

            return letter;
        }

        public static void DisplayResults(double prd, string letter, double g1, double g2, double g3, double g4, double g5)
        {
            double avgRnd = Math.Round(prd, 2);
            
            Console.Write("\nThe average of your scores (");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}%, {1}%, {2}%, {3}%, {4}%", g1, g2, g3, g4, g5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(prd+"%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(",\nwhich is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(avgRnd+"%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" rounded, and that is a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(letter);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");
        }
    }
}
