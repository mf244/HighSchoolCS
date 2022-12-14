/*
 Name: Matthew Floyd
Date: 10/21/22
Program: EX11_CountingNums
Prompt: You are to read an external file of random integer values until the end of
file is found. As you read the file you should determine how many numbers are less than the
value 500 and how many numbers are greater than or equal to 500
 */

using System;
using System.IO;

namespace MFEX11_CountingNumbers
{
    class CountingNums
    {
        static void Main()
        {
            string phrase = null;

            using (StreamReader mattyF = new StreamReader("Data215a.txt")) //Reads the data from the file
            {
                phrase = mattyF.ReadLine(); //Because the entire data stream is on one line in the file, this gets all of that data at once
            }


            string[] nums = phrase.Split(',');//This splits the files data at the commas


            int under = 0;//All three counters
            int over = 0;
            int total = 0;

            foreach (var num in nums) //For each number, it converts and checks
            {

                if (Convert.ToInt32(num) < 500)
                {
                    under++;
                    total++;//Both counters are here because the program is counting total as well as the under/over
                }
                if (Convert.ToInt32(num) >= 500)
                {
                    over++;
                    total++;
                }
                
                
                
            }

            Console.WriteLine("The number of numbers less than 500 is {0}", under);
            Console.WriteLine("The number of numbers greater than or equal to 500 is {0}", over);
            Console.WriteLine("The total number of numbers is {0}", total);
        }
    }
}
