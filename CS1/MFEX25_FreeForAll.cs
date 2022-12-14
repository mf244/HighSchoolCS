using System;

namespace MFEX25_FreeForAll
{
    class MFEX25_FreeForAll
    {
        #region IntroandEnding
        public static void Intro(string anm, string pnm, string cdt, string prp, int w, int h)
        {
  
            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
        }
        
        


         public static void Ending()
        {
            Console.WriteLine("\n\n-----Please press any key to end-----");
            Console.ReadKey();
        }
        #endregion
        static void Main()
        {
            #region callIntro
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX25_FreeForAll";
            const string CREATION_DATE = "12/16/21";
            const string PURPOSE = "Do whatever you feel like";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion
            
        GoAgain:
            string answer = DisplayPhrase();
            string enteredAnswer = GetAnswer(); 
            bool correctness = CheckAnswer(answer, enteredAnswer); //I'm not sure if there's a better way to do this, but it's the only one I could tell
            DisplayResults(correctness, answer);
            
            string more = AskForMore();
            
            if (more == "y")
            {
                goto GoAgain; //I am using a goto statement because it makes more sense in my mind so please chill out
            }
            else
            {
                Ending();
            }
        }

        public static string DisplayPhrase()
        {
            //Console.WriteLine("DEBUG the class for displayphrase was called");
            Random randy = new Random();
            int num = randy.Next(1, 9);//Im trying to find a way to get it to not pick a riddle it's picked before
            string answer = "";//This time I actually remembered the whole thing about assigning the variable first so it exists in the method to be returned
           // Console.WriteLine("DEBUG"+ num);
            if(num == 1)
            {
                Console.WriteLine("What has to be broken before you can use it?: A(n) ____");
                answer = "egg";
            }
            else if(num == 2)
            {
                Console.WriteLine("What is always in front of you but can’t be seen?: The ____");
                answer = "future";
            }
            else if(num == 3)
            {
                Console.WriteLine("What gets wet while drying?: A(n) ____");
                answer = "towel";
            }
            else if(num == 4)
            {
                Console.WriteLine("I have branches, but no fruit, trunk or leaves. What am I?: A(n) ____");
                answer = "bank";
            }
            else if(num == 5)
            {
                Console.WriteLine("What can’t be put in a saucepan?: It's ____");
                answer = "lid";
            }
            else if(num == 6)
            {
                Console.WriteLine("What has hands, but can’t clap?: A(n) ____");
                answer = "clock";
            }
            else if(num == 7)
            {
                Console.WriteLine("What has one head, one foot and four legs?: A(n) ____");
                answer = "table";
            }
            else if(num == 8)
            {
                Console.WriteLine("What runs all around a backyard, yet never moves?: A(n) ____");
                answer = "fence";
            }
            else if(num == 9)
            {
                Console.WriteLine("It stalks the countryside with ears that can’t hear. What is it?: ____");
                answer = "corn";
            }
            return answer;

        }

        public static string GetAnswer()
        {
            Console.Write("Please enter your answer: ");
            string enteredAnswer = Console.ReadLine();
            return enteredAnswer.ToLower(); //I couldnt figure out how to get this to work again but finally got it with adding a variable name, then helped Isabella
        }

        public static bool CheckAnswer(string a, string ea)
        {
            if (a == ea)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DisplayResults(bool thing, string ans)
        {
            if (thing == true)
            {
                Console.Beep(500, 250);
                Console.Beep(750, 250);
                Console.WriteLine("Great job! That's the answer.");
            }
            else
            {
                Console.Beep(750, 250);
                Console.Beep(500, 250);
                Console.WriteLine("Aw man! That's not right, the answer is: {0}", ans);
            }
        }
        
        public static string AskForMore()
        {
            Console.Write("Would you like another riddle (y/n)?: ");
            string anudda = Console.ReadLine();
            Console.Write("\n\n"); //I added these as a suggestion from greg to make it look better, but originally had it below the return and didnt know why it wasnt working.
            return anudda.ToLower();
        }
    }
}
