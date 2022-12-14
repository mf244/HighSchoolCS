using System;

namespace MFEX34_Counting2
{
    class MFEX34_Counting2
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
            
   
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}

        
        static void Main()
        {

           #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX34_Counting2";
const string CREATION_DATE = "2/28/22";
const string PURPOSE = "To learn do while.\n";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion

          

            do
            {
                for (int i = 2; i < 21; i += 2)
                {
                    Console.Write(i + " ");

                }

                Console.WriteLine(""); //This is the most efficent way I found for this to work

                for (int i = 20; i > 1; i -= 2) //In the prompt it sounded like you wanted one loop but I saw no way to do this
                {
                    Console.Write(i + " ");

                }

                Console.WriteLine("\nWould you like to run again? (y/n)");
                
            } while (Console.ReadLine().ToLower() == "y"); //I enhanced my knowledge of string methods


            End();



        }
    }
}
