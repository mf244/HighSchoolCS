/*
 * 
 Each method:
Print first in
tell what it will do
do it (and assign to new var
print new var
return new var
 * 
 */



using System;

namespace MFEX25B_LargeStringProgram
{
    class MFEX25B_LargeStringProgram
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
                    
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }
        #endregion
       
        static void Main()
        {
            #region CallStart
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX25B_LargeStringProgram";
            const string CREATION_DATE = "1/6/21";
            const string PURPOSE = "To learn string modifiers";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion
            
            #region TextInput //ONLY RUN THIS OR BYPASS
            /*
            string task1String1 = GetInput(" I pledge allegiance to the Flag ");
            Continue();

            string task2String2 = GetInput("of the *weather is nice*United States of America");
            Continue();

            string task3String3 = GetInput("and to the Republic for which it stands");
            Continue();

            string task4String4 = GetInput("one *Na*tion under* God, indiv*isible,");
            Continue();

            string task5String5 = GetInput("WITH LIBERTY AND JUSTICE FOR ALL.");
            Continue();
            */
            #endregion

            #region Bypass //ONLY RUN THIS OR TextInput

            string task1String1 = " I pledge allegiance to the Flag ";
            Console.WriteLine("The string is: (START){0}(END)", task1String1);
            Continue();

            string task2String2 = "of the *weather is nice*United States of America";
            Console.WriteLine("The string is: {0}", task2String2);
            Continue();

            string task3String3 = "and to the Republic for which it stands";
            Console.WriteLine("The string is: {0}", task3String3);
            Continue();

            string task4String4 = "one *Na*tion under* God, indiv*isible,";
            Console.WriteLine("The string is: {0}", task4String4);
            Continue();

            string task5String5 = "WITH LIBERTY AND JUSTICE FOR ALL.";
            Console.WriteLine("The string is: {0}", task5String5);
            Continue();

            #endregion

            
            
            string correctedStr1 = Task1Meth(task1String1);
            Continue();

            string correctedStr2 = Task2Meth(task2String2);
            Continue();

            string correctedStr3 = Task3Meth(task3String3);
            Continue();

            string correctedStr4 = Task4Meth(task4String4);
            Continue();

            string correctedStr5 = Task5Meth(task5String5);
            Continue();



            Task6Meth(correctedStr1, correctedStr2, correctedStr3, correctedStr4, correctedStr5);

            End();
        }

        public static string GetInput(string temp)
        {
            Console.WriteLine("Please enter the phrase: {0}", temp);
            return Console.ReadLine();
        }

        public static void Continue()
        {
            Console.WriteLine("Press any key to continue and clear the screen");
            Console.ReadKey();
            Console.Clear();
        }

        #region Tasks
        public static string Task1Meth(string tmp) //Decided it would be helpful to mark start and end here so you can see things happen
        {
            Console.WriteLine("The original string for task one is: (START){0}(END)", tmp);
            Console.WriteLine("This method will trim the blank spaces from the ends.");
            string corrected = tmp.Trim();
            Console.WriteLine("The new string is: (START){0}(END)", corrected);
            return corrected;

        }

        public static string Task2Meth(string tmp) //I'm not sure this is the most efficent way to do this, but its the way i figured out
        {
            Console.WriteLine("The original string for task two is: {0}", tmp);
            Console.WriteLine("This method will remove the stars and content in between.");
            int firstStar = tmp.IndexOf("*");
            int secondStar = tmp.LastIndexOf("*");
            string corrected = tmp.Remove(firstStar, (secondStar-firstStar+1));
            Console.WriteLine("The new string is: {0}", corrected);
            return corrected;
        }

        public static string Task3Meth(string tmp)
        {
            Console.WriteLine("The original string for task three is: {0}", tmp);
            Console.WriteLine("This method will add a comma on the end.");
            string corrected = tmp + ",";
            Console.WriteLine("The new string is: {0}", corrected);
            return corrected;
        }

        public static string Task4Meth(string tmp)
        {
            Console.WriteLine("The original string for task four is: {0}", tmp);
            Console.WriteLine("This method will remove the stars.");
            string corrected = tmp.Replace("*", "");
            Console.WriteLine("The new string is: {0}", corrected);
            return corrected;
        }

        public static string Task5Meth(string tmp)
        {
            Console.WriteLine("The original string for task five is: {0}", tmp);
            Console.WriteLine("This method will make it all lowercase.");
            string corrected = tmp.ToLower();
            Console.WriteLine("The new string is: {0}", corrected);
            return corrected;
            
        }

        public static void Task6Meth(string s1, string s2, string s3, string s4, string s5)
        {
            Console.WriteLine("This method will combine all of the strings and count the length");
            string final = s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5; 
            int length = final.Length;
            Console.WriteLine("The final string is: {0}", final);
            Console.WriteLine("The length of this string is: {0} characters", length); //I'm not sure if this is the proper length, or how to tell.
        }
        #endregion
    }
}
