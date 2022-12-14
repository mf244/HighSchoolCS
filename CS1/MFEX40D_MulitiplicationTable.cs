using System;

namespace MFEX40D_MulitiplicationTable
{
    class MFEX40D_MulitiplicationTable
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
        
        
        static void Main()
        {
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX40D_MultiplicationTable";
const string CREATION_DATE = "3/21/22";
const string PURPOSE = "To learn multiplication in more loops";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            Console.Write("How large would you like your table?: ");
            int tableSize = Convert.ToInt32(Console.ReadLine());
            if (tableSize <= 20)
            {
                for (int i = 1; i <= tableSize; i++) //Had this as just < first so was off by 1
                {
                    for (int x = 1; x <= tableSize; x++)
                    {
                        Console.Write("{0}\t", i*x);//This is basically the whole program
                    }
                    Console.WriteLine("\n"); //Adds another line break
                }
            }
            
            End();
           
        }
    }
}
