using System;

namespace MFEX6_Depreciation
{
    class MFEX6_Depreciation
    {
        static void Main()
        {
            string runAgain = "n";
            
            do
            {
                Console.Write("Please enter the original value: ");
                int originalValue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the scrap value: ");
                int scrapValue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the estimated life value: ");
                int estimatedLife = Convert.ToInt32(Console.ReadLine());

                int sumYears = GetSumYears(estimatedLife);
                int depSum = originalValue - scrapValue;

                PrintChart(estimatedLife, originalValue, depSum, sumYears);

                Console.Write("Would you like to run again? (y/n): ");
                runAgain = Console.ReadLine();
            } while (runAgain == "y");
        }


        public static void PrintChart(int estLife, int orVal, int depSum, int SumYrs)
        {

            int cumuDep = 0;
            Console.WriteLine("Year\tValue\tDepr\tCumulative Depr");
            for (int i = 0; i <= estLife; i++)
            {
                Console.Write(i);
                Console.Write("\t");
                orVal = orVal - cumuDep;
                Console.Write(orVal);
                Console.Write("\t");
                int tempDep = ((estLife - i) / SumYrs) * (depSum);
                Console.Write(tempDep);
                Console.Write("\t");
                cumuDep = (tempDep * (depSum)) + cumuDep;
                Console.Write(cumuDep);
                Console.WriteLine("");

            }
        }
        public static int GetSumYears(int life)
        {
            int sumYears = 0;

            do
            {
                sumYears = sumYears + life;
                life--;
            } while (life != 0);

            return sumYears;
        }
    }
}
