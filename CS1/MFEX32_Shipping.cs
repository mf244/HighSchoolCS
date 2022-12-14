using System;

namespace MFEX32_Shipping
{
    class MFEX32_Shipping
    {
        #region Start
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.Clear();
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
        static void Main()
        {
            #region CallStart
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX32_Shipping";
            const string CREATION_DATE = "2/11/22";
            const string PURPOSE = "To use if statements again and learn the && and <=\n";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion
            
            double purchases = GetPurchases("your total cost (above zero with no $ symbol)");

            double shippingCost = FindCost(purchases);

            double net = FindNet(purchases, shippingCost); //Is this even a main method?

            DisplayResults(purchases, shippingCost, net);

            End();
        }

        public static double GetPurchases(string temp)
        {
            Console.Write("Please enter {0}: ", temp);
            return Convert.ToDouble(Console.ReadLine()); //No recursion because people arent gigaknuckleheads
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
            return cost; //No recursion dealwittit
        }

        public static double FindNet(double pur, double cst)
        {
            return pur - cst; //This method is literally genius and you cant say otherwise
        }

        public static void DisplayResults(double pur, double cst, double net)
        {
            Console.WriteLine("\nWith a purchase cost of: {0:C2}\nYou get a shipping cost of: {1:C2}\nWhich leaves you with a net cost of: {2:C2}", pur, cst, net);
        }
    }
}
