using System;

namespace MFEX20B_ClubProceeds
{
    class MFEX20B_ClubProceeds
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX20B_ClubProceeds";
            const string CREATION_DATE = "12/8/21";
            const string PURPOSE = "To learn a freakton of methods with math.";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            const double BARS_PER_CASE = 12;
            const double COST_CASE = 5;
            const double GOV_CUT = 0.10;
            double casesBought = GetDouble("amount of cases bought");
            double priceBar = GetDouble("price per bar");
            double grossProceeds = FindGross(BARS_PER_CASE, casesBought, priceBar);
            double totalSpent = PurchaseCost(casesBought, COST_CASE);
            double profBeforeTax = ProfitBeforeTax(grossProceeds, totalSpent);
            double govsCut = GovCut(profBeforeTax, GOV_CUT);
            double finalProfit = ClubProceeds(profBeforeTax, govsCut);
            DisplayResults(BARS_PER_CASE, COST_CASE, casesBought, priceBar, grossProceeds, totalSpent, govsCut, finalProfit); //called more vars than I needed first
            Ending();
        }


        public static void DisplayResults(double bpc, double cc, double cb, double pb, double gp, double ts, double fgc, double profit)
        {
            Console.WriteLine("When there are cases with {0} bars per case at {1:C2} a case: Sales of {2} cases at {3:C2} per bar results in a gross proceed of {4:C2}. After factoring in a final spent of {5:C2} and a government tax of {6:C2}, the clubs final money made is {7:C2}", bpc, cc, cb, pb, gp, ts, fgc, profit);
        }


        public static double ClubProceeds(double pbt, double cut)
        {
            return pbt - cut; //These math things are really easy
        }

        public static double GovCut(double prof, double tax)
        {
            return prof * tax;
        }
        public static double ProfitBeforeTax(double made, double spent)
        {
            return made - spent;
        }

        public static double PurchaseCost(double cases, double price)
        {
            return cases * price;
        }

        public static double FindGross(double bars, double cases, double price)
        {
            return bars * cases * price;
        }

        public static double GetDouble(string temp) //I rewrote this because I dont have it in my toolbox
        {
            Console.WriteLine("Please enter the {0}.", temp);
            return Convert.ToDouble(Console.ReadLine());  
        }
        
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
            
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("-----Please press any key to end-----");
            Console.ReadKey();
        }
    }
}
