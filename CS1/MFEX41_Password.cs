using System;

namespace MFEX41_Password
{
    class MFEX41_Password
    {
        public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}\n", anm, pnm, cdt, prp);       
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
const string PROGRAM_NAME = "EX41_Password";
const string CREATION_DATE = "3/25/22";
const string PURPOSE = "To learn loomps and strings";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            int i = 5;//I changed this a couple time, just changes how it displays
            while (i > 0)
            {
                string atmp = GetAttempt(i);
                if (atmp != "Lynch")
                {
                    i--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ForegroundColor = ConsoleColor.White;
                    i = 0; //This is right i think
                }
            }

            End();
        }


        public static string GetAttempt(int temp)
        {
            Console.Write("You have ");
            Console.ForegroundColor = ConsoleColor.DarkCyan; //Good color 10/10
            Console.Write(temp);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" attempts remaining. Please input a guess: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string attempt = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return attempt;
        }
    }
}
