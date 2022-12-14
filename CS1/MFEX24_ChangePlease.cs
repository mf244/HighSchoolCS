using System;

namespace MFEX24_ChangePlease
{
    class MFEX24_ChangePlease
    {
        static void Main()
        {
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "MFEX24_ChangePlease";
            const string CREATION_DATE = "12/14/21";
            const string PURPOSE = "To learn about alot of consts and complex methods";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Intro(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
           
            const int TWENTY_PENNY_VAL = 2000;
            const int TEN_PENNY_VAL = 1000;
            const int FIVE_PENNY_VAL = 500;
            const int ONE_PENNY_VAL = 100;
            const int QUART_PENNY_VAL = 25;
            const int DIME_PENNY_VAL = 10;
            const int NICKEL_PENNY_VAL = 5;
            const int PENNY_PENNY_VAL = 1;
           
            double totalCost = GetInput("total cost of the item purchased");
            double amtPaid = GetInput("total amount of money paid");
            
            int totalChangePennies = GetChange(totalCost, amtPaid);
            int totalTwenties = DivTemp(totalChangePennies, TWENTY_PENNY_VAL);
            int remainderTwenties = ModuloTemp(totalChangePennies, TWENTY_PENNY_VAL);
            int totalTens = DivTemp(remainderTwenties, TEN_PENNY_VAL);
            int remainderTens = ModuloTemp(remainderTwenties, TEN_PENNY_VAL);
            int totalFives = DivTemp(remainderTens, FIVE_PENNY_VAL);
            int remainderFives = ModuloTemp(remainderTens, FIVE_PENNY_VAL);
            int totalOnes = DivTemp(remainderFives, ONE_PENNY_VAL);
            int remainderOnes = ModuloTemp(remainderFives, ONE_PENNY_VAL);
            int totalQuarts = DivTemp(remainderOnes, QUART_PENNY_VAL);
            int remainderQuarts = ModuloTemp(remainderOnes, QUART_PENNY_VAL);
            int totalDimes = DivTemp(remainderQuarts, DIME_PENNY_VAL);
            int remainderDimes = ModuloTemp(remainderQuarts, DIME_PENNY_VAL);
            int totalNickels = DivTemp(remainderDimes, NICKEL_PENNY_VAL);
            int remainderNickels = ModuloTemp(remainderDimes, NICKEL_PENNY_VAL);
            int totalPennies = DivTemp(remainderNickels, PENNY_PENNY_VAL); //That was a lot of code

            DisplayResults(totalCost, amtPaid, totalChangePennies, totalTwenties, totalTens, totalFives, totalOnes, totalQuarts, totalDimes, totalNickels, totalPennies);
            Ending();        
        }

        
         public static void Intro(string anm, string pnm, string cdt, string prp, int w, int h)
        {
  
            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
        }
        
        
        public static double GetInput(string temp)
        {
            Console.Write("Please enter the {0}: ", temp);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static int GetChange(double c, double p)
        {
            return Convert.ToInt32((p - c) * 100);
        }

        public static int DivTemp(int temp1, int temp2)
        {
            return temp1 / temp2; //Method called every time
        }

        public static int ModuloTemp(int temp1, int temp2)
        {
            return temp1 % temp2;
        }

        public static void DisplayResults(double cst, double pd, int chng, int tw, int te, int fv, int on, int qu, int di, int ni, int pe)
        {
            Console.WriteLine("Amount due: {0:C2}\nTotal paid: {1:C2}\nTotal change in pennies: {2}", cst, pd, chng); //Change in pennies :)
            Console.Write("Your change is:\nTwenties: {0}\nTens: {1}\nFives: {2}\nOnes: {3}\nQuarters: {4}\nDimes: {5}\nNickels: {6}\nPennies: {7}", tw, te, fv, on, qu, di, ni, pe);
        }

        public static void Ending()
        {
            
            Console.WriteLine("\n-----Please press any key to end-----");
            Console.ReadKey();
        }

    }
}
