using System;

namespace MFEX31_PayRoll
{
    class MFEX31_PayRoll
    {
        #region Start
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
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
const string PROGRAM_NAME = "EX31_PayRoll";
const string CREATION_DATE = "2/7/22";
const string PURPOSE = "To learn switch statements\n";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion //Dan doesnt like how this is formatted
            
            
            const double TAX_TAX = 0.18;
            const double RETIRE_TAX = 0.10;
            const double SOCIAL_TAX = 0.06;
            EntireProgram(TAX_TAX, RETIRE_TAX, SOCIAL_TAX);


End();
        }

        public static void DisplayCurrency(string temp1, double temp2) //This entire method is so I can do colors easier
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(temp1);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0:C2}", temp2); //This took me forever to figure out
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static double GetDouble(string temp) //I added this because you made me
        {
            Console.Write("Please enter {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double intput = Convert.ToDouble(Console.ReadLine()); //Couldn't just return this so I could do the color
            Console.ForegroundColor = ConsoleColor.White;
            return intput;
        }

        public static void EntireProgram(double TAX_TAX, double RETIRE_TAX, double SOCIAL_TAX)
        {
            
            double type = GetDouble("1 if you are salaried or 2 if you are hourly");

            switch (type)
            
            {
                case 1:
                  
                    double salary = GetDouble("your salary");

                    DisplayCurrency("Your salary is: ", salary);

                    
                    double tax = salary * TAX_TAX;
                    DisplayCurrency("The tax on that is: ", tax);

                    
                    double retirement = salary * RETIRE_TAX;
                    DisplayCurrency("Your retirement costs are: ", retirement);

                   
                    double social = salary * SOCIAL_TAX;
                    DisplayCurrency("And your costs for social security are: ", social);

                    double takeHome = salary - tax - retirement - social;
                    DisplayCurrency("This means your final take home pay is: ", takeHome);
                    break;

                case 2:
                    
                    double rate = GetDouble("how much you get paid hourly");

                    double hours = GetDouble("how many hours you work");

                    double hourly = rate * hours;

                    DisplayCurrency("Your pay is: ", hourly);

                    
                    double hourTax = hourly * TAX_TAX;
                    DisplayCurrency("The tax on that is: ", hourTax);

                    
                    double hourRetirement = hourly * RETIRE_TAX;
                    DisplayCurrency("Your retirement costs are: ", hourRetirement);

                    
                    double hourSocial = hourly * SOCIAL_TAX;
                    DisplayCurrency("And your costs for social security are: ", hourSocial);

                    double hourTakeHome = hourly - hourTax - hourRetirement - hourSocial;
                    DisplayCurrency("This means your final take home pay is: ", hourTakeHome);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ur a knucklehead, try again"); 
                    Console.ForegroundColor = ConsoleColor.White;
                    EntireProgram(TAX_TAX, RETIRE_TAX, SOCIAL_TAX);
                    break;
            }
        }
    }
}
