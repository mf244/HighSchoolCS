using System;

namespace MFEX39_Shipping2
{
    
    class MFEX39_Shipping2
    {

        public static bool DoMore()
        {
            Console.Write("Would you like to run again? (y/n): ");
            Console.ForegroundColor = ConsoleColor.Red;
            string again = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            bool boolie = false;
            if (again == "y") //This was really satisfying to figure out
            {
                boolie = true;
                Console.WriteLine(" ");
            }

            return boolie;

        }


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

        static void Main() //This is not a fake main its literally what you told me to do
        {
            
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX39_Shipping2";
const string CREATION_DATE = "3/11/22";
const string PURPOSE = "To learn more loops";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            
            bool testercle = false;
            do
            {
                double grossCost = TotalCost();
                Calculate(grossCost);
                testercle = DoMore();
            } while (testercle);
            
            End();
        }

        public static void Calculate(double gross)
        {
            double shipping = FindCost(gross);
            double tax = 0.07 * gross;
            double final = gross + tax + shipping;

            Console.WriteLine("\nItemized Summary:");
            Console.WriteLine("Total cost of all items: {0:C2}", gross);
            Console.WriteLine("Sales tax: {0:C2}", tax);
            Console.WriteLine("Shipping cost: {0:C2}", shipping);
            Console.WriteLine("Final cost due: {0:C2}", final);
        }
        
        public static double TotalCost()
        {
            double temp = 0;
            double counter = 1; //Originally thought I didnt need this, but realized I did.
            double final = 0;
            do
            {
                Console.Write("Please enter the price of item {0} (0 to exit): ", counter);
                temp = Convert.ToDouble(Console.ReadLine());
                final = temp + final;
                counter++;
               
            } while (temp != 0); //Took me a second to figure out what this was
            
            return final;
        }
        
        public static double FindCost(double pur)
        {
            double cost = 0.00;
            if (pur > 0 && pur <= 250)
            {
                cost = 5.00;
            }
            else if (pur > 250.01 && pur <= 500.00)
            {
                cost = 8.00;
            }
            else if (pur > 500.01 && pur <= 1000.00)
            {
                cost = 10.00;
            }
            else if (pur > 1000.01 && pur <= 5000.00)
            {
                cost = 15.00;
            }
            else if (pur > 5000.00)
            {
                cost = 20.00;
            }
            return cost; 
        }
    }
}
