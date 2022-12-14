using System;

namespace MFEX29_Months
{
    class MFEX29_Months
    {
        #region Start
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
}
#endregion

#region end
public static void End()
{
            
   
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}
#endregion
        
        static void Main() //This program was surprising difficult especially because I never actually learned switch statements or recursion
        {
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX29_Months";
const string CREATION_DATE = "2/1/22";
const string PURPOSE = "To learn switch statements and recursion and\nreally nested if statements and leap year formulas\n";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            int month = GetMonth("month as a number(1 for Jan, 12 for Dec)");
            int year = GetYear("year the month is in"); // I know I have two get methods but it's literally the only way I could get recursion working

            CheckInt(month, year);
End();
        }

        public static int GetMonth(string temp)
        {
            Console.Write("Please enter the {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            int month = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if (month < 1 || month > 12)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not an integer from 1-12, try again knucklehead!");
                Console.ForegroundColor = ConsoleColor.White;
                month = GetMonth("month as a number(1 for Jan, 12 for Dec)");
            }
            return month;
            
        }

        public static int GetYear(string temp) //The same thing but for years
        {
            Console.Write("Please enter the {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            int year = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if (year < 1 || year > 9999)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not an integer from 1-9999, try again knucklehead!");
                Console.ForegroundColor = ConsoleColor.White;
                year = GetYear("year the month is in");
            }
            return year;
            
        }


        public static void CheckInt(int month, int year)
        {
           

            switch (month)
            {
                case 1:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("January ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("31 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 2:
                    #region FEBURARY
                    // I used the formulas from here: https://docs.microsoft.com/en-us/office/troubleshoot/excel/determine-a-leap-year 

                    bool leapYear = false; //Took me forever to realise I needed this line
                    

                    if (year%4 == 0) //I have no idea if this is how i was supposed to do it, but i just used the logic from the article and a boolean
                    {
                        if (year%100 == 0)
                        {
                            if (year%400 == 0)
                            {
                                leapYear = true;
                            }
                            else
                            {
                                leapYear = false;
                            }
                        }
                        else
                        {
                            leapYear = true;
                        }
                    }
                    else
                    {
                        leapYear = false; 
                    }

               


                    if (leapYear)
                    {
                        Console.Write("That month is ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Feburary ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("and ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(year);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" is a leap year so it has ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("29 ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("days.");
                    }
                    else
                    {
                        Console.Write("That month is ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Feburary ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("and ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(year);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" is not a leap year so it has ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("28 ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("days.");
                    }
                    break;



                #endregion
                case 3:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("March ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("31 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 4:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("April ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("30 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 5:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("May ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("31 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 6:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("June ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("30 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 7:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("July ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("31 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 8:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("August ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("31 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 9:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("September, when my birthday is! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("So it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("30 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 10:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("October ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("31 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 11:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("November ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("30 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                case 12:
                    Console.Write("That month is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("December ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("so it has ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("31 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("days.");

                    break;
                default:
                   //I don't think I need anything here because recursion in the other methods handles knuckleheads?
                    break;
                    
                    
            } //End of switch statement
           
        } //Ennd of check int method
    } //End of class
} //End of namespace
