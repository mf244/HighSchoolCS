using System;

namespace MFEX26_Discriminant
{
    class MFEX26_Discriminant
    {
       
        #region Start
        public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
        {   
  
            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
        }   
        #endregion

        #region end
        public static void End()
        {
                    
            
            Console.WriteLine("\n-----Please press any key to end-----");
            Console.ReadKey();
        }
        #endregion
        
        
        
        
        static void Main()
        {
            #region CallStart
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX26_Discriminant";
            const string CREATION_DATE = "1/20/22";
            const string PURPOSE = "To use if else statements to make the discriminant show results.\n\n";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion
            
            Console.WriteLine("f(x) = Ax^2 + Bx + C");

            double inA = GetDouble("first number");
            double inB = GetDouble("second number");
            double inC = GetDouble("third number");

            double discrim = FindDiscriminant(inA, inB, inC);
            Display(discrim, inA, inB, inC);

            End();
        }
        
        public static double FindDiscriminant(double vala, double valb, double valc)
        {
            return Math.Pow(valb, 2) - 4 * vala * valc;    //I had originally assigned these as strings and fixed that      
        }

        public static double GetDouble(string temp)
        {
            Console.Write("To calculate the discriminant please enter the {0}: ", temp);
            return Convert.ToDouble(Console.ReadLine()); //First I had this assigning a variable to return, but I realised I could do it this way
            
        }

        public static void Display(double discrim, double inA, double inB, double inC)
        {
            Console.WriteLine("\nThe discriminant is {0}", discrim);
            if (discrim < 0)
            {
                Console.WriteLine("That number is negative.");
                Console.WriteLine("Therefore, the polynomial is f(x) = {0}x^2+{1}x+{2}", inA, inB, inC);
                Console.WriteLine("This means that there are no real roots.");
            }
            else if (discrim == 0)
            {
                Console.WriteLine("That number is 0.");
                Console.WriteLine("Therefore, the polynomial is f(x) = {0}x^2+{1}x+{2}", inA, inB, inC);
                Console.WriteLine("This means there is one double root");//Im not sure if there was a more efficent way to do this, but this works
            }
            else if (discrim > 0)
            {
                Console.WriteLine("That number is positive.");
                Console.WriteLine("Therefore, the polynomial is f(x) = {0}x^2+{1}x+{2}", inA, inB, inC);
                Console.WriteLine("This means there are two roots.");
            }

        }
    }
}
