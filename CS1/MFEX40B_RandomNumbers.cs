using System;

namespace MFEX40B_RandomNumbers
{
    class MFEX40B_RandomNumbers
    {
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
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
            Console.WriteLine(" ");
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
const string PROGRAM_NAME = "EX40B_RandomNumbers";
const string CREATION_DATE = "3/15/22";
const string PURPOSE = "To learn random and looping";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion

            Console.WriteLine("-----Please press any key to start-----");
            Console.ReadKey();
            Console.WriteLine(" ");


            Random randy = new Random();

            int even = 0; //Realized I had to initialize out here
            int small = 100;
            int large = 0;


            do
            {

                even = 0;
                small = 1000;
                large = 0;


                for (int i = 1; i <= 100; i++) //I had 1000 first. Oops!
                {


                    int newRand = randy.Next(1, 1001);
                    Console.WriteLine("{0}: {1}", i, newRand);
                    if ((newRand % 2) == 0) 
                    {
                        even++;
                    }
                    if (newRand < small)
                    {
                        small = newRand;
                    }
                    if (newRand > large)
                    {
                        large = newRand;
                    }
                    

                   
                }

                int range = large - small;

                Console.WriteLine("\nSmallest: {0}", small);
                Console.WriteLine("Largest: {0}", large);
                Console.WriteLine("Range: {0}", range);
                Console.WriteLine("Number of evens {0}", even);
            } while (DoMore());

            //Not even gonna try the extra credit I dont feel like spending time on it

            End();
        }
    }
}
