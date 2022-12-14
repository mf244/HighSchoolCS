/*
 Name: Matthew Floyd
Date: 10/22/22
Program Name: EX12_AvoidTheDups
Prompt: Use a single-subscripted
array to solve the
following problem. Read
in 20 numbers, each of
which is between 10 and
100, inclusive. As each
number is read, print it
only if it is not a duplicate
of a number already
read. Provide for the
"worst case" in which all
20 numbers are different
Use the smallest
possible array to solve
this problem.
 */

using System;
using System.IO;
using System.Linq; //This initializes the Distinct method

namespace MFEX12_AvoidTheDups
{
    class EX12_AvoidTheDups
    {
        static void Main()
        {
            string phrase = null; 

            using (StreamReader mattyF = new StreamReader("P415h.txt"))
            {
                phrase = mattyF.ReadLine();
            }


            string[] withDups = phrase.Split(' '); //Splits the file at the spaces

            String[] withoutDups = withDups.Distinct().ToArray(); //Makes a new array with the duplicates removed

            Console.WriteLine("The original set of numbers are: ");

            foreach (var item in withDups)
            {
                Console.Write(" "+Convert.ToString(item)); //Prints the numbrs from the original array
            }

            Console.WriteLine("\nThe set of numbers without dups are: ");

            foreach (var item in withoutDups)
            {
                Console.Write(" "+Convert.ToString(item)); 
            }

            using (StreamWriter myWriter = new StreamWriter("AvoidTheDups.txt")) //Writes to file 
            {
                myWriter.Write("The original set of numbers are:");

                foreach (var item in withDups) 
                {
                    myWriter.Write(" "+Convert.ToString(item));
                }

                myWriter.Write("\n The different numbers from the set of integers are:"); //I needed to put the newline here to make the thing work properly

                foreach (var item in withoutDups)
                {
                    myWriter.Write(" "+Convert.ToString(item));
                }
            }
        }
    }
}
