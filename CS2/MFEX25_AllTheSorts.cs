/*Name: Matthew Floyd
 * Program Name: Ex25_AllTheSorts
 * Date: 12/12/22
 * Prompt: bubble sort int and word arrays and use two more sort types
 */
using System;
using System.IO;
using System.Linq;

namespace MFEx25_AllTheSorts
{
    internal class MFEx25_AllTheSorts
    {
        static void Main()
        {
            int[] intArrayBeforeSort = RandomIntArray(100);
            Console.WriteLine("Int array before sorting");
            PrintIntArray(intArrayBeforeSort);

            int[] intArrayAfterBubbleSort = BubbleInt(intArrayBeforeSort);
            Console.WriteLine("Int array after bubble sort");
            PrintIntArray(intArrayAfterBubbleSort);

            string[] stringArrayBeforeSort = GetStringArray();
            Console.WriteLine("String array before sorting");
            PrintStringArray(stringArrayBeforeSort);

            string[] stringArrayAfterBubbleSort = BubbleString(stringArrayBeforeSort);
            Console.WriteLine("String array after bubble sort");
            PrintStringArray(stringArrayAfterBubbleSort);

            int[] intAfterInsertion = IntInsertion(intArrayBeforeSort);
            Console.WriteLine("Int array after insertion sort");
            PrintIntArray(intAfterInsertion);


            int leftIndexInt = 0, rightIndexInt = ((intArrayBeforeSort.Length) - 1);
            int[] intAfterQuick = IntQuick(intArrayBeforeSort, leftIndexInt, rightIndexInt);
            Console.WriteLine("Int array after quick sort");
            PrintIntArray(intAfterQuick);

            string[] stringAfterInsertion = StringInsertion(stringArrayBeforeSort);
            Console.WriteLine("String array after Insertion sort");
            PrintStringArray(stringAfterInsertion);

            int leftIndexString = 0, rightIndexString = ((stringArrayBeforeSort.Length) - 1);
            string[] stringAfterQuick = StringQuick(stringArrayBeforeSort, leftIndexString, rightIndexString);
            Console.WriteLine("String array after quick sort");
            PrintStringArray(stringAfterQuick);

        }

        public static int[] RandomIntArray(int numInts)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 5000);
            int[] array = new int[numInts];

            for (int i = 0; i < numInts; i++)
            {
                array[i] = rnd.Next(1, 5000);
            }
            return array;
        }

        public static void PrintIntArray(int[] array)
        {
            Console.WriteLine("\n");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        public static int[] BubbleInt(int[] intArray)
        {
            int temp;
            for (int j = 0; j < intArray.Length - 1; j++)
            {
                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            return intArray;
        }

        public static string[] GetStringArray()
        {
            string[] array = new string[50];
            using (StreamReader beans = new StreamReader("words.txt"))
            {
                for (int i = 0; i < 50; i++)
                {
                    array[i] = beans.ReadLine();
                }
            }
            return array;
        }

        public static void PrintStringArray(string[] array)
        {
            Console.WriteLine("\n");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        public static string[] BubbleString(string[] stringArray)
        {
            string temp;
            for (int j = 0; j < stringArray.Length - 1; j++)
            {
                for (int i = 0; i < stringArray.Length - 1; i++)
                {
                    if (stringArray[i].CompareTo(stringArray[i + 1]) > 0)
                    {
                        temp = stringArray[i + 1];
                        stringArray[i + 1] = stringArray[i];
                        stringArray[i] = temp;
                    }

                }
            }
            return stringArray;
        }

        public static int[] IntInsertion(int[] array)
        {
            int i, j, val, flag;//These numbers change throughout the whole sort
            for (i = 1; i < array.Length; i++)//Goes through every number in the array
            {
                val = array[i];//Gets the value of the (second) value for every comparison
                flag = 0;//Lets the bringing number down loop break if at end
                for (j = i - 1; j >= 0 && flag != 1;)//Runs a comparison against every number below (second) value
                {
                    if (val < array[j])//Checks if (Second) position is less than (first) position
                    {
                        array[j + 1] = array[j];//Swaps (second) value with position below it
                        j--;
                        array[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            return array;
        }


        public static int[] IntQuick(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;//Takes index of 0 from outside the method to make the recursion work properly
            var j = rightIndex;//Takes index of length-1 from outside the method
            var pivot = array[leftIndex];//Assigns the pivot as the leftmost variable
            while (i <= j)//Runs while the left index is less than or equal to the right
            {
                while (array[i] < pivot)//If the tested number is less than the pivot
                {
                    i++;//Moves the left value to the right one num
                }

                while (array[j] > pivot)//If the right value is greater than the pivot
                {
                    j--;//Moves the right value to the left one num
                }
                if (i <= j)//If the left selector is <= the right selector
                {
                    int temp = array[i];
                    array[i] = array[j];//Swaps the left and right selectors to continue loop
                    array[j] = temp;
                    i++;//Moves the selectors in
                    j--;
                }
            }

            if (leftIndex < j)
            {
                IntQuick(array, leftIndex, j);
            }
            //Both of these cases check if the selectors overlap which means the loop needs to be run again with the new pivot
            if (i < rightIndex)
            {
                IntQuick(array, i, rightIndex);
            }

            return array;
        }

        public static string[] StringInsertion(string[] array)
        {
            string val;
            int i, j, flag;
            for (i = 1; i < array.Length; i++)
            {
                val = array[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo(array[j]) < 0)//This is the only different line from the int insertion, compares ascii values of (first) and (second) numbers
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            return array;
        }

        public static string[] StringQuick(string[] array, int leftIndex, int rightIndex) 
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i].CompareTo(pivot) > 0)//This comparison and the one below are the only that change for string as the other compare index positions
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                StringQuick(array, leftIndex, j);
            }
            
            if (i < rightIndex)
            {
                StringQuick(array, i, rightIndex);
            }

            return array;

        }
    }
}
