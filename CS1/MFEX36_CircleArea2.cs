using System;

namespace MFEX36_CircleArea2
{
    class MFEX36_CircleArea2
    {

        public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
        {

            Console.WindowWidth = w;
            Console.WindowHeight = h;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);
        }


        public static void End()
        {


            Console.WriteLine("\n-----Please press any key to end-----");
            Console.ReadKey();
        }




        static void Main()
        {
            #region CallStart
            const string AUTHOR_NAME = "Matthew Floyd";
            const string PROGRAM_NAME = "EX36_CircleArea2";
            const string CREATION_DATE = "3/1/22";
            const string PURPOSE = "To learn state controlled while loops with a 0 to end";
            const int WINDOW_WIDTH = 90;
            const int WINDOW_HEIGHT = 45;
            Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
            #endregion


            bool moreData = true;
            while (moreData) 
            {
                //I put spaces in my main method :)

                double radius = GetDouble("the radius of the circle (0 to end)" );

                if (radius != 0) //Not sure this is the best way, but it works beautifully
                {
                    double area = Calculate(radius);

                    Display(radius, area);


                    moreData = true;
                }
                else
                {
                    moreData = false;
                }

                

            }

            End();
        }

        //I was completely able to get rid of the method that checks for go again

        public static double Calculate(double r)
        {
            return Math.PI * Math.Pow(r, 2);

        }

        public static double GetDouble(string temp)
        {
            Console.Write("\nPlease enter {0}: ", temp);
            Console.ForegroundColor = ConsoleColor.Red;
            double var = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            return var;
        }

        public static void Display(double r, double a) //Not much else to comment because its the same
        {
            Console.Write("The area of a circle with a radius of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(r);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" has an area of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0:N2}", a);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");
        }


    }
}
