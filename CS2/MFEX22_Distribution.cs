using System;

namespace MFEx22_Distribution
{
    class MFEx22_Distribution
    {
        static void Main()
        {
            string runAgain = "n";
            do
            {
                Console.Clear();
                int[] diceSum = fillArray();

                PrintGraph(diceSum);

                Console.Write("Would you like to run again? (y/n): ");
                runAgain = Console.ReadLine();
            } while (runAgain == "y");

        }


        public static int[] fillArray()
        {
            int[] diceSum = new int[51];
            for (int i = 0; i <= 50; i++)
            {
                int roll1 = Roll();
                int roll2 = Roll();

                int sum = roll1 + roll2;

                diceSum[i] = sum;
            }

            return diceSum;
        }

        public static int Roll()
        {
            Random randy = new Random();
            return randy.Next(1, 7);

        }

        public static void PrintGraph(int[] diceSum)
        {
            
            Console.SetCursorPosition(0, 0);
            Console.Write("-");

            int rowSet = 5;

            for (int i = 2; i <= 12; i++)
            {
                Console.SetCursorPosition(rowSet, 0);
                Console.Write(i);
                rowSet = rowSet+5;
            }
           
            
           

            Console.SetCursorPosition(0, 1);
            Console.Write("----------------------------------------------------------------");

            int[] rowCounter = new int[12];
            for (int i = 0; i < 12; i++)
            {
                rowCounter[i] = 2;
            }


            for (int i = 0; i <= 50; i++)
            {
                switch (diceSum[i])
                {
                    case 2:
                        Console.SetCursorPosition(5, rowCounter[1]);
                        Console.Write("x");
                        rowCounter[1] = rowCounter[1] + 1;
                        break;
                    case 3:
                        Console.SetCursorPosition(10, rowCounter[2]);
                        Console.Write("x");
                        rowCounter[2] = rowCounter[2] + 1;
                        break;
                    case 4:
                        Console.SetCursorPosition(15, rowCounter[3]);
                        Console.Write("x");
                        rowCounter[3] = rowCounter[3] + 1;
                        break;
                    case 5:
                        Console.SetCursorPosition(20, rowCounter[4]);
                        Console.Write("x");
                        rowCounter[4] = rowCounter[4] + 1;
                        break;
                    case 6:
                        Console.SetCursorPosition(25, rowCounter[5]);
                        Console.Write("x");
                        rowCounter[5] = rowCounter[5] + 1;
                        break;
                    case 7:
                        Console.SetCursorPosition(30, rowCounter[6]);
                        Console.Write("x");
                        rowCounter[6] = rowCounter[6] + 1;
                        break;
                    case 8:
                        Console.SetCursorPosition(35, rowCounter[7]);
                        Console.Write("x");
                        rowCounter[7] = rowCounter[7] + 1;
                        break;
                    case 9:
                        Console.SetCursorPosition(40, rowCounter[8]);
                        Console.Write("x");
                        rowCounter[8] = rowCounter[8] + 1;
                        break;
                    case 10:
                        Console.SetCursorPosition(45, rowCounter[9]);
                        Console.Write("x");
                        rowCounter[9] = rowCounter[9] + 1;
                        break;
                    case 11:
                        Console.SetCursorPosition(50, rowCounter[10]);
                        Console.Write("x");
                        rowCounter[10] = rowCounter[10] + 1;
                        break;
                    case 12:
                        Console.SetCursorPosition(55, rowCounter[11]);
                        Console.Write("x");
                        rowCounter[11] = rowCounter[11] + 1;
                        break;


                    default:
                        break;
                }
            }

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Done");
        }
    }
}
