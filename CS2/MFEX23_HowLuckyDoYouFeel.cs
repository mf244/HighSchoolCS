/*
 * Name: Matthew Floyd
 * Date: 12/7/22
 * Program Name: EX23_HowLuckyDoYouFeelV2
 * Prompt: Play a numbers betting game against your friend 10,000 times. Print the percentage you win
 */
using System;

namespace MFEX23_HowLuckyDoYouFeelV2
{
    internal class MFEX23_HowLuckyDoYouFeel
    {
        static void Main(string[] args)
        {
            string runAgain;
            do
            {
                int wincounter = 0;//Counter that counts how much you win
                int samecounter = 0;//This counter makes it possible to keep the "same" condition through the entire game if one is found


                for (int i = 1; i <= 10000; i++)
                {
                    samecounter = 0;
                    int[] personOne = GetArray();//Gets the random, non repeating arrays

                    int[] personTwo = GetArray();


                    for (int j = 0; j < personOne.Length; j++)
                    {//These two for loops combined go through every possible combination of the array nums
                        for (int k = 0; k < personTwo.Length; k++)
                        {
                            if (personOne[j] == personTwo[k])
                            {
                                samecounter++;//Adds the the same counter, this gave me hell because I realized I was wiping it after every time
                            }
                        }
                    }
                    if (samecounter == 0)
                    {
                        wincounter++;//Took me a while to understand that if there are no same numbers, you win
                    }

                }
                double total = (double)wincounter / 10000;//This worked once I realized what the actual win condition is
                Console.WriteLine("The total percentage of no matches (you winning) in all games is {0:P2}", total);


                Console.Write("Would you like to run again? (y/n): ");
                runAgain = Console.ReadLine();
            } while (runAgain == "y");
            
            

            
        }

        public static int[] GetArray()//Checks for matching numbers in the single (new) array
        {
            int[] temp = new int[10];

            for (int i = 0; i <= 9;)//There is no counter in this loop in order to run again if there is a duplicate
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 101);

                //This big if statement checks if the new random number is equal to anything already in the array, and if is not adds it and progresses the counter
                if (temp[0] != num && temp[1] != num && temp[2] != num && temp[3] != num && temp[4] != num && temp[5] != num && temp[6] != num && temp[7] != num && temp[8] != num && temp[9] != num)
                {
                    temp[i] = num;
                    i++;
                }
               
            }

            return temp;
        }

        
    }
}
