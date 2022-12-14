using System;

namespace MFEX38_Grades2
{
    class MFEX38_Grades2
    {
      
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
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
const string PROGRAM_NAME = "EX38_Grades2";
const string CREATION_DATE = "3/9/22";
const string PURPOSE = "To learn sentinel controlled and other crap";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            bool testercle = false; //I used the funny
            do
            {
                Console.WriteLine("");
                double average = GetAverage();
                string letterGrade = GetLetter(average);
                #region Display
                Console.Write("The average of your scores is");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" {0:N2} ", average);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("which is a(n)");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" {0}", letterGrade);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");
                #endregion
                testercle = DoMore();
            } while (testercle);

            End();
            
        }

        public static double GetDouble(string temp)
        {
            Console.Write("Please enter a {0} (-999 to end): ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            double doubleput = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            return doubleput;
        }

        public static double GetAverage()
        {
            double tempNum = 0; //Love initializing outside
            int testCounter = 1;
            double finalScore = 0;
            while (tempNum != -999)
            {
                
                tempNum = GetDouble("score for test "+testCounter);

                if (tempNum > 100 || tempNum < 0) //This is definitely innefficent
                {
                    if (tempNum != -999)
                    {
                        Console.WriteLine("Error");
                    }
                    
                    
                }
                else
                {
                    finalScore = tempNum + finalScore;
                    testCounter++;
                    //Console.WriteLine("DEBUG The current sum of scores is "+finalScore);
                }
                
                
            }
            double average = finalScore / (testCounter-1); //I think this was the only way to avoid the off by 1
            //Console.WriteLine("DEBUG the average as of finishCollect is "+average);
            return average;
        }

        public static string GetLetter(double avg)
        {
            string letter = "";

            if (avg <= 100.00 && avg >= 89.50)
            {
                letter = "A";
            }
            else if (avg <= 89.49 && avg >= 79.50) 
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
            else if (avg <= 59.49 && avg >= 0.00)
            {
                letter = "F";
            }

            return letter;
        }

        public static bool DoMore() //Return of DoMore
        {
            Console.Write("\nWould you like to run again? (y/n): ");
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
    }
}
