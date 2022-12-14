/*
 Title: EX1_UlamHypothesis
Name: Matthew Floyd
Date Started: 8/29/22 (I was bored so I did this program before the first day of school :))
Prompt: The mathematician Stanislau Ulam of the University of Colorado hypothesized that any positive integer would always converge to 1 if 
treated as follows If it is odd, muftiply it by three and add 1 If it is even, divide it by 2 The procedure is then applied to the result of 
each calculation. For example, starting with eleven, the following is produced: 11 34 17 52 26 13 4020 105 16 8421 Write a program that tests 
this theory and shows the output for all numbers from to 25. 
 */




using System;

namespace MFEX1_UlamHypothesis
{
    class MFEX1_UlamHypothesis
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            
           int outp = 0; // Comes up with a second variable so we don't change the counter
            int counter = 1; //Will go 1-25


            while (counter <= 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(counter+": ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                
                while (outp != 1) //I added this after some thinking, makes it end once 1 is hit
                {
                    if (outp == 0) //I realized i needed a way to check if it was the first cycle, to start from the counter, and this was it
                    {
                        if (counter%2 == 0)
                        {
                            outp = counter / 2; //first actual assignment of the output
                            Console.Write(outp+" ");
                        }
                        else if (counter%2 == 1)
                        {
                            outp = (counter * 3) + 1;
                            Console.Write(outp+" ");
                        }
                    }

                    if (outp != 1) //My number 2 was broken, so I added this to only run if the top cell didnt get the answer
                    {
                        if (outp % 2 == 0) //same as above, but uses output variable to not change counter after initial number
                        {
                            outp = outp / 2;
                            Console.Write(outp + " ");
                        }
                        else if (outp % 2 == 1)
                        {
                            outp = (outp * 3) + 1;
                            Console.Write(outp + " ");
                        }
                    }
                    
                    
                }
                Console.WriteLine(); //Adds a line break
                counter++; //resets output and increases counter for next loop
                outp = 0;
            }
            

         End();


        }

        public static void End()
        {
            
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-----Please press any key to end-----");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
