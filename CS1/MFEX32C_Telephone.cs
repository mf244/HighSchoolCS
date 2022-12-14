using System;

namespace EX32C_Telephone
{
    class MFEX32C_Telephone
    {
        #region Start
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}\n", anm, pnm, cdt, prp);       
}
#endregion
        #region end
public static void End()
{
            
   
    Console.WriteLine("\n-----Please press any key to end-----");
    Console.ReadKey();
}
#endregion
        
        static void Main()
        {
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "MFEX32C_Telephone";
const string CREATION_DATE = "2/17/22";
const string PURPOSE = "To learn recursion in a switch finally which I didnt";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            string char1 = GetChar("first");
            int int1 = Check(ref char1); //So this esentially runs it with char1 or charS depending on recursion

            string char2 = GetChar("second");
            int int2 = Check(ref char2);
            
            string char3 = GetChar("third");
            int int3 = Check(ref char3);
            
            string char4 = GetChar("fourth");
            int int4 = Check(ref char4);
            
            string char5 = GetChar("fifth");
            int int5 = Check(ref char5);
            
            string char6 = GetChar("sixth");
            int int6 = Check(ref char6);
            
            string char7 = GetChar("seventh");
            int int7 = Check(ref char7);
            
            string char8 = GetChar("eigth");
            int int8 = Check(ref char8);
            
            string char9 = GetChar("ninth");
            int int9 = Check(ref char9);
            
            string char10 = GetChar("tenth");
            int int10 = Check(ref char10);



            Display(char1,char2,char3,char4,char5,char6,char7,char8,char9,char10,int1,int2,int3,int4,int5,int6,int7,int8,int9,int10);

            End();
        }

        public static string GetChar(string temp)
        {
            Console.Write("Please enter the {0} digit: ", temp);
            string b4lower = Console.ReadLine();
            return b4lower.ToLower();

        }

        public static int Check(ref string charS)//This is getting input from recursion below
        {

           
            int returnME = 0;
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
                    returnME = Convert.ToInt32(charS);//I know you didnt like this but I aint tryna do all the cases seperately
                    break;

                case "a":
                case "b":
                case "c":
                    returnME = 2;
                    break;

                case "d":
                case "e":
                case "f":
                    returnME = 3;
                    break;

                case "g":
                case "h":
                case "i":
                    returnME = 4;
                    break;

                case "j":
                case "k":
                case "l":
                    returnME = 5;
                    break;

                case "m":
                case "n":
                case "o":
                    returnME = 6;
                    break;

                case "p":
                case "q":
                case "r":
                case "s":
                    returnME = 7;
                    break;

                case "t":
                case "u":
                case "v":
                    returnME = 8;
                    break;

                case "w":
                case "x":
                case "y":
                case "z":
                    returnME = 9;
                    break;



                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're a knucklehead");
                    Console.ForegroundColor = ConsoleColor.White;
                    charS = GetChar("correctly formatted");
                    returnME = Check(ref charS); //I still don't completely get this but i'll look into it
                    break;
                    
                    

                    
            }
            return returnME;
        }

        public static void Display(string char1, string char2, string char3, string char4, string char5, string char6, string char7, string char8, string char9, string char10, int int1, int int2, int int3, int int4, int int5, int int6, int int7, int int8, int int9, int int10)
        {
            Console.WriteLine("\nYour inputted phone number is ({0}{1}{2})-{3}{4}{5}-{6}{7}{8}{9}", char1, char2, char3, char4, char5, char6, char7, char8, char9, char10);
            Console.WriteLine("Your converted phone number is ({0}{1}{2})-{3}{4}{5}-{6}{7}{8}{9}", int1, int2, int3, int4, int5, int6, int7, int8, int9, int10);
        }
    }
}
