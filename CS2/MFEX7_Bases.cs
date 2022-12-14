/*
 Name: Matthew Floyd
Date: 10/4/22
Project: EX7_Bases
Prompt:  Write a program that will print out a table of numbers 0 to 35 in decimal, hex, octal, and binary notation. 
 */

using System;

namespace MFEX7_Bases
{
    class MFEX7_Bases
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            

            string runAgain;
            do
            {
                Console.Clear();
                Console.WriteLine("Please pick an option:\n1. Print numbers 0-35\n2. Enter a number\n3. Enter a range of numbers\n");
                string choice = Console.ReadLine();

                switch (choice) //This is all for the menu system, as i wanted my code to be able to do more things
                {
                    case "1":
                        OptionOne();
                        break;

                    case "2":
                        OptionTwo();
                        break;

                    case "3":
                        OptionThree();
                        break;
                }

                Console.Write("Would you like to run again? (y/n): ");
                runAgain = Console.ReadLine();
            } while (runAgain == "y");
            
        }

        public static void OptionOne()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n10\t16\t8\t2");
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i <= 35; i++) //Loops around 35 times, not user set
            {
                string ten = Convert.ToString(i);
                string sixteen = GetB16(i);
                string eight = GetB8(i);//All of these lines use seperate methods to make stuff happen
                string two = GetB2(i);

                Console.WriteLine(ten + "\t" + sixteen + "\t" + eight + "\t" + two);
            }
        }

        public static void OptionTwo()
        {
            Console.Write("Please enter a number to convert to bases: ");
            int numIn = Convert.ToInt32(Console.ReadLine()); //Allows the user to enter number that they want in bases

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n10\t16\t8\t2");
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;


            string ten = Convert.ToString(numIn);
                string sixteen = GetB16(numIn);
                string eight = GetB8(numIn);//These skip the loop, and send in the pure number
                string two = GetB2(numIn);

                Console.WriteLine(ten + "\t" + sixteen + "\t" + eight + "\t" + two);
            
        }

        public static void OptionThree()
        {
            Console.Write("Please enter the bottom of the range you would like: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the top of the range you would like: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n10\t16\t8\t2");
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = firstNum; i <= secondNum; i++) //This loop uses the bottom and top numbers to convert a range
            {
                string ten = Convert.ToString(i);
                string sixteen = GetB16(i);
                string eight = GetB8(i);
                string two = GetB2(i);

                Console.WriteLine(ten + "\t" + sixteen + "\t" + eight + "\t" + two);
            }

        }
        public static string reverseString(string s)

        {

            string reversed = "";



            for (int i = s.Length - 1; i >= 0; i--) //This part took me forever to figure pout how to do, I had to ask Henry for help

            { //Essentially it runs through all the chars in reverse order and builds a new string

                reversed += s[i];

            }



            return reversed;

        }
        public static string GetB16(int i)
        {
            string finalOut = "";

            do //it took me forever to get all of the loop brackets in the right place

            {

                if (i % 16 >= 10) //Originally had an issue with the program taking a multi-digit number, added this to fix it

                {

                    switch (i % 16) //Finds letter if number is greater than 10

                    {

                        case 10:

                            finalOut += "A";

                            break;

                        case 11:

                            finalOut += "B";

                            break;

                        case 12:

                            finalOut += "C";

                            break;

                        case 13:

                            finalOut += "D";

                            break;

                        case 14:

                            finalOut += "E";

                            break;

                        case 15:

                            finalOut += "F";

                            break;

                    }

                }

                else

                {

                    finalOut += i % 16; //Does the normal calculation if number is not over 10

                }

                i /= 16; //Sets the var up for the next run

            } while (i > 0); //Loops through until zero is reached



            return reverseString(finalOut);
        }

        
        public static string GetB8(int i)
        {
            string finalOut = "";

            do

            {

                finalOut += i % 8; //Very easy, just pure clean math

                i /= 8;

            } while (i > 0);



            return reverseString(finalOut);
        }

        public static string GetB2(int i)
        {
            string finalOut = "";

            do

            {

                finalOut += i % 2;

                i /= 2; //Same as B8, just easy math

            } while (i > 0);



            return reverseString(finalOut);
        }

        
    }
}
