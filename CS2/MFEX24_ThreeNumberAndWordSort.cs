/* Name: Matthew Floyd
 * Date: 12/10/22
 * Program Name: Ex24_ThreeNumberAndWordSort
 * Prompt: Sort groups of three numbers and groups of three words
 */

using System;
using System.IO;
using System.Xml.Linq;

namespace MFEx24_ThreeNumberAndWordSort
{
    internal class MFEx24_ThreeNumberAndWordSort
    {
        static void Main()
        {
            Console.Write("Would you like to run part one (1), part two (2), or both (3)?: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    partOneMain();
                    break;
                case "2":
                    partTwoMain();
                    break;
                case "3":
                    partOneMain();
                    partTwoMain();
                    break;
                default:
                    Console.WriteLine("invalid option");
                    Main();
                    break;
            }

        }

        public static void partOneMain()//Calls all the method needed for the first part of the prompt
        {

            Console.WriteLine("\nSTART PART ONE\n");
            using (StreamReader beans = new StreamReader("threeNumberSortData.txt"))
            {
                string line = "start";//Initializes this out here because my conditions dont work otherwise
                while (line != null)//This is the actual loop
                {
                    line = beans.ReadLine();//This is where it actually reads from file
                    if (line != null)//Not sure why or if I need this, but I think it makes it more reliable
                    {
                        string[] stringArray = line.Split(' ');//Splits one line into a string array of however large it needs to be
                        int[] array = MakeIntArray(stringArray);//Converts the string array of ints to int array
                        BubbleIntRev(ref array);//Sends array by reference to sort array

                        foreach (var item in array)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                        
                    
                }

            }
        }

        public static void partTwoMain()//The "main" for the second part, calls all the methods
        {
            Console.WriteLine("\nSTART PART TWO\n");
            string[] stringArray;

            using (StreamReader beansTwo = new StreamReader("threeWordSortData.txt"))
            {
                string line = "start";
                while (line != null)
                {
                    line = beansTwo.ReadLine();//I had a bunch of trouble with the logic around here in both, took a bit of swapping out ifs and whiles
                    if (line != null)
                    {
                        stringArray = line.Split(' ');//Splits my string array and sends into my string bubblesort method
                        BubbleString(ref stringArray);

                        for (int i = 0; i < stringArray.Length; i++)
                        {
                            Console.Write(stringArray[i]+" ");
                        }
                        Console.WriteLine("");

                    }
                    
                }
                
                   
            }
        }

        public static int[] MakeIntArray(string[] stringArray)//This method converts string array to int array like before
        {
            int length = stringArray.Length;
            int[] intArray = new int[length];

            int i = 0;
            foreach (var item in stringArray)
            {
                intArray[i] = Convert.ToInt32(item);
                i++;
            }

            return intArray;
        }

        public static void BubbleIntRev(ref int[] array)//I decided to just make an actual bubble sort method instead of doing the whole swap thing
        {
            int temp;//Sets up for the swap part
            for (int j = 0; j < array.Length - 1; j++)//Counter for which number to start on, accepts an array of any length
            {
                for (int i = 0; i < array.Length - 1; i++)//Counter for going up
                {
                    if (array[i] < array[i + 1])//Checks the two positions of the array to see if the numbers need to be swapped
                    {
                        temp = array[i + 1];//Swaps the numbers, similar to the swap method you wanted me to make except it works directly in the array
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

        public static void BubbleString(ref string[] stringArray)//A bubble sort method for strings, again it was easier to just code it and have it. 
        {
            string temp;
            for (int j = 0; j < stringArray.Length - 1; j++)//Same logic here as the other bubble method
            {
                for (int i = 0; i < stringArray.Length - 1; i++)
                {
                    if (stringArray[i].CompareTo(stringArray[i+1]) > 0)//Instead of doing a direct comparison, compares the ASCII values
                    {
                        temp = stringArray[i + 1];
                        stringArray[i + 1] = stringArray[i];
                        stringArray[i] = temp;
                    }

                }
            }
        }
    }
}
