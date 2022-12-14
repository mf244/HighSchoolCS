/*
 Name: Matthew Floyd
Program Name: EX9_CarSalesman
Date: 10/19/22
Prompt: Use a single-subscripted array to solve the following problem. A car
dealer pays its salespeople on a commission basis. The salesperson receives $200 per week
plus 9 percent of their gross sales for that week. For
example a salesperson who grosses $5000 in sales in a
week receives $200 plus 9 percent of $5000, or a total of
$650 (truncate to the nearest dollar). Write a
program that determines how many of the sales
people earned salaries in each of the following 
 */

using System;
using System.IO;

namespace MFEx9_CarSalesman
{
    class Ex9_CarSalesman
    {
        static void Main()
        {
            

            int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0, cnt5 = 0, cnt6 = 0, cnt7 = 0, cnt8 = 0, cnt9 = 0; //initializing all the counters


            try //using a try catch here in case the file does not exist
            {
                string phrase = null;
             
                using (StreamReader mattyF = new StreamReader("prices.txt"))
                {
                    phrase = mattyF.ReadLine(); //Because the entire data stream is on one line in the file, this gets all of that data at once
                }

                
                string[] beforeList = phrase.Split(' '); //Splits the big string with spaces at the spaces into a string array

                foreach (var tempString in beforeList) //Makes a new temp variable for the increasing index number in the string array
                {
                    double tempDouble = Convert.ToDouble(tempString);
                    tempDouble = (tempDouble * 0.09) + 200; //These two lines convert to double and then do the math
                    

                    if (tempDouble >= 200 && tempDouble < 300) //Big ass if ladder, pretty self explanatory
                    {
                        cnt1++;
                    }
                    else if (tempDouble >= 300 && tempDouble < 400)
                    {
                        cnt2++;
                    }
                    else if (tempDouble >= 400 && tempDouble < 500)
                    {
                        cnt3++;
                    }
                    else if (tempDouble >= 500 && tempDouble < 600)
                    {
                        cnt4++;
                    }
                    else if (tempDouble >= 600 && tempDouble < 700)
                    {
                        cnt5++;
                    }
                    else if (tempDouble >= 700 && tempDouble < 800)
                    {
                        cnt6++;
                    }
                    else if (tempDouble >= 800 && tempDouble < 900)
                    {
                        cnt7++;
                    }
                    else if (tempDouble >= 900 && tempDouble < 1000)
                    {
                        cnt8++;
                    }
                    else if (tempDouble >= 1000 && tempDouble < 1100)
                    {
                        cnt9++;
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
               
            }

            Console.WriteLine("Salary\tFrequency"); //Down here all of the things get printed out 
            Console.WriteLine("$200-$299\t"+cnt1);
            Console.WriteLine("$300-$399\t" + cnt2);
            Console.WriteLine("$400-$499\t" + cnt3);
            Console.WriteLine("$500-$599\t" + cnt4);
            Console.WriteLine("$600-$699\t" + cnt5);
            Console.WriteLine("$700-$799\t" + cnt6);
            Console.WriteLine("$800-$899\t" + cnt7);
            Console.WriteLine("$900-$999\t" + cnt8);
            Console.WriteLine("$1000-$1099\t" + cnt9);
           
        }
    }
}
