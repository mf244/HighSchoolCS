using System;

namespace MFEX33_Counting

{
    


    
    
    class MFEX33_Counting
    {


        public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
        {

            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);
        }


        public static void End()
        {


            Console.WriteLine("\n-----Please press any key to end-----");
            Console.ReadKey();
        }
        static void Main()
        {

            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX33_Counting";
const string CREATION_DATE = "2/23/22";
const string PURPOSE = "To learn counters and for/while loops\n";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion

    



            for (int i = 1; i < 21; i++)
            {
                if (i<9) //I learned how to make this one for loop
                {
                    Console.WriteLine(i);
                }
                else if (i > 9) //I got rid of the >= and just changed the number
                {
                    Console.Write(i+" ");
                }
            } // Originally, I had a condition for a 9, but I realized I just dont need anything


            End();
        }
    }
}
