using System;

namespace MFEX32B_GeometricVolume
{
    class MFEX32B_GeometricVolume
    {
        #region Start
public static void Start(string anm, string pnm, string cdt, string prp, int w, int h)
{
  
    Console.WindowWidth = w;
    Console.WindowHeight = h;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.Clear();
    Console.WriteLine("Hello! Welcome to another awesome program written by {0}.\nThis program is called {1} and was created on {2}.\nThe purpose of this program is as follows:\n{3}", anm, pnm, cdt, prp);       
}
#endregion

        #region end
public static void End()
{
            
 
    Console.WriteLine("-----Please press any key to end-----");
    Console.ReadKey();
}
#endregion
        
        static void Main()
        {
            #region CallStart
const string AUTHOR_NAME = "Matthew Floyd";
const string PROGRAM_NAME = "EX32B_GeometricVolume";
const string CREATION_DATE = "2/15/22";
const string PURPOSE = "To learn recursion and casting";
const int WINDOW_WIDTH = 90;
const int WINDOW_HEIGHT = 45;
Start(AUTHOR_NAME, PROGRAM_NAME, CREATION_DATE, PURPOSE, WINDOW_WIDTH, WINDOW_HEIGHT);
#endregion
            Console.WriteLine("\n1. Sphere\n2. Rectangular Prism\n3. Cylinder");
            double choice = GetInt("the corresponding number");
            double volume = GetVolume(choice);
            DisplayResults(volume);

            End();
        }

        public static int GetInt(string temp)
        {
            Console.Write("Please enter {0}: ", temp);
            int tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp <= 0 || tmp > 3)
            {
                Console.WriteLine("Nice job knucklehead");
                return GetInt(temp);
            }
            else
            {
                return tmp;
            }
        }//I know you dont like recursion in two methods like this, but I can't get it to work in the switch
        
        public static double GetDouble(string temp)
        {
            Console.Write("Please enter {0}: ", temp);
            double tmp = Convert.ToDouble(Console.ReadLine());
            if ( tmp <= 0 )
            {
                Console.WriteLine("Good job kuucklehead");
                return GetDouble(temp);
            }
            else
            {
                return tmp;
            }
        }

        public static double GetVolume(double choice)
        {
            double volume = 1;
            
            switch (choice)
            {
                default:
                

                    break;

                case 1:
                    Console.WriteLine("You chose a sphere.");
                    double radiusSphere = GetDouble("radius of the sphere");
                    volume = (double)4 / 3 * (Math.PI) * (Math.Pow(radiusSphere, 3));//This was giving me the wrong value because I didnt cast lol

                    break;

                case 2:
                    Console.WriteLine("You chose a Rectangular Prisim");
                    double length = GetDouble("the length of the prisim");
                    double width = GetDouble("the width of the prisim");
                    double heightPrisim = GetDouble("the height of the prisim");
                    volume = length * width * heightPrisim;
                    break;

                case 3:
                    Console.WriteLine("You chose a cylinder.");
                    double radiusCylinder = GetDouble("the radius of the cylinder");
                    double heightCylinder = GetDouble("the height of the cylinder");
                    volume = (Math.PI) * (Math.Pow(radiusCylinder, 2)) * heightCylinder;
                    break;
            }

            return volume;
        }

        public static void DisplayResults(double vol)
        {
            Console.WriteLine("The volume of your shape is: {0:N3}", vol); //Fake method lol
        }
    }
}
