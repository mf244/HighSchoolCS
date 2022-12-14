/*
(5 points) - People sometimes give their telephone number using one or more alphabetic characters.  Write a program that uses a for loop to accept a 10-digit telephone number that may contain one or more alphabetic characters.  Display both the letters entered and the corresponding phone number using numerals.  Be sure to include the parentheses around the area code and the hyphen when setting up your for loop.    
o    Use the same SwitchMethod from the program from the last unit as a good place to start, but I would suggest having it return the numerical value as a string instead of the numerical value as an integer value.

o    I would also suggest using an AskUserForString(int i) method inside your for loop so you can display the counter.

o    Modify it by adding a loop (a for loop is suggested because you know you want it to loop 10 times, but you could use a while loop if your prefer) to make the program smaller.  This will eliminate the need for 10 different digit variables and 10 different convertedDigit variables like the last program.  You will NOT be able to use your old Display method here. 
*/




using System;

namespace MFEX40C_Telephone
{
    class EX40C_Telephone
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
const string PROGRAM_NAME = "EX40C_Telephone";
const string CREATION_DATE = "3/21/22";
const string PURPOSE = "To learn for loops and if statements inside and APARRENTLY NOT STRING METHODS";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
           
            string preCon = "(";
            string postCon = "(";

            for (int i = 1; i < 11; i++)
            {

               
                string digNo = "digit " + i;
                string tempChar = GetString(digNo);
                preCon = preCon + tempChar;
                string tempChar2 = Check(tempChar);
                postCon = postCon + tempChar2;

                if (i == 3) //Took me a minute to figure this out
                {
                    preCon = preCon + ")-";
                    postCon = postCon + ")-";
                }
                if (i == 6)
                {
                    preCon = preCon + "-";
                    postCon = postCon + "-";
                }
            }

            /*
            I tried to use this, but you yelled at me
            
            #region InsertFormatting
            preCon = preCon.Insert(0, "(");
            preCon = preCon.Insert(4, ")");
            preCon = preCon.Insert(5, "-");
            preCon = preCon.Insert(9, "-");

            postCon = postCon.Insert(0, "(");
            postCon = postCon.Insert(4, ")");
            postCon = postCon.Insert(5, "-");
            postCon = postCon.Insert(9, "-");

            #endregion
             */
           

            Console.WriteLine("Your first number is "+preCon);
            Console.WriteLine("Your second number is "+postCon);
            
            End();
        }


        public static string Check(string charS)
        {
            

            string returnME = "";
            switch (charS)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    returnME = charS; //Edited this to return a string
                    break;

                case "a":
                case "b":
                case "c":
                    returnME = "2";
                    break;

                case "d":
                case "e":
                case "f":
                    returnME = "3";
                    break;

                case "g":
                case "h":
                case "i":
                    returnME = "4";
                    break;

                case "j":
                case "k":
                case "l":
                    returnME = "5";
                    break;

                case "m":
                case "n":
                case "o":
                    returnME = "6";
                    break;

                case "p":
                case "q":
                case "r":
                case "s":
                    returnME = "7";
                    break;

                case "t":
                case "u":
                case "v":
                    returnME = "8";
                    break;

                case "w":
                case "x":
                case "y":
                case "z":
                    returnME = "9";
                    break;



                



            }
            return returnME;
        }

        public static string GetString(string temp) //My entire method for this got deleted from the toolbox so its not fancy
        {
            Console.Write("Please enter {0}: ", temp);
            return Console.ReadLine().ToLower();
        }
    }
}
