/*
 Name: Matthew Floyd
Date: 11/9/22
Program name: Ex15_Arrays_TicTacToe
Prompt: Create a two-dimensional 3 by 3 array.  
Perform a compile-time array that stores either an ‘X’ or an ‘O’.  
Make your array so ‘X’’s win the game of tic-tac-toe going from top right, to bottom left.  
Display your array nicely as a game board.  Assume ‘X’ went first.
 */
using System;

namespace MFEx15_Arrays_TicTacToe
{
    class Ex15_Arrays_TicTacToe
    {
        static void Main()
        {
            string[,] array = new string[3, 3]; //Initializes a new array, 3 rows and 3 columns
            array[0, 2] = "x";//Places an x in spot 1, 3. This is array 0, 2. This gave me a bug originally, I was out of bounds of the array
            
            printBoard(array);//Goes to my print board method, it took me a while to figure out how to send arrays to methods
           

            array[1, 2] = "o";

            printBoard(array);
            

            array[1, 1] = "x";

            printBoard(array);

            array[2, 1] = "o";

            printBoard(array);

            array[2, 0] = "x";

            printBoard(array);


        }

        
        public static void printBoard(string[,] array)//This took me forever to get right like getting the array in
        {
           
            Console.WriteLine("Press any key to see the next move"); //Makes it possible to not print the entire array at once
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(array[0, 0] + "\t" + array[0, 1] + "\t" + array[0, 2] + "\t\n");//These lines take care of formatting and printing, and also gave me the out of bounds issue
            Console.WriteLine(array[1, 0] + "\t" + array[1, 1] + "\t" + array[1, 2] + "\t\n");
            Console.WriteLine(array[2, 0] + "\t" + array[2, 1] + "\t" + array[2, 2] + "\t\n");
        }

        
    }
}
