using System;
using System.Text.RegularExpressions;

//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

// 15. Given a three-digit integer as input write a C# program to determine whether the number is an Armstrong number. 
// An Armstrong number is one for which the sum of each digit raised to the power of number of digits results 
// in the number itself.
// For a three digit number 153 = 13 + 53 + 33
// None confine to 3 digit examples only ie., number values 100…999.
// Minor comment change
namespace CSPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryagain = true;

            while(tryagain)
            {
                Console.Write("Please enter a three-digit integer: ");

                string input;

                while (true)
                {
                    input = Console.ReadLine();

                    if (Int32.TryParse(input, out int A) && Regex.IsMatch(input, @"^[0-9]{3}$"))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Please just enter a three-digit integer: ");
                    }
                }

                Console.WriteLine();
                int B = Convert.ToInt32(input);
                Console.WriteLine($"You've entered {B}.");

                // 3-digit integer ABC has C as first digit (position or power 0), 
                // B as second digit (position or power 1) 
                // and A as third digit (position or power 2)
                int firstdigit = (int)((B / Math.Pow(10, 0)) % 10);
                int seconddigit = (int)((B / Math.Pow(10, 1)) % 10);
                int thirddigit = (int)((B / Math.Pow(10, 2)) % 10);

                Console.WriteLine($"In the ONES place is {firstdigit}.");
                Console.WriteLine($"In the TENS place is {seconddigit}.");
                Console.WriteLine($"In the HUNDREDS place is {thirddigit}.");
                Console.WriteLine();
                Console.Write("Is {0} an Armstrong number?", B);
                Console.WriteLine(" i.e. Is {0} = {1}^3 + {2}^3 + {3}^3 ?", B, thirddigit, seconddigit, firstdigit);
                Console.WriteLine();
                double third = Math.Pow((double)thirddigit, 3);
                double second = Math.Pow((double)seconddigit, 3);
                double first = Math.Pow((double)firstdigit, 3);
                double sum = first + second + third;
                Console.WriteLine("\t{0}^3 = {1}", thirddigit, third);
                Console.WriteLine("\t{0}^3 = {1}", seconddigit, second);
                Console.WriteLine("\t{0}^3 = {1}", firstdigit, first);
                Console.WriteLine("-----------------------");
                Console.WriteLine("\tSUM = {0}", sum);
                Console.WriteLine();
                if ((int)sum == B)
                {
                    Console.WriteLine("{0} is an Armstrong number!", B);
                    Console.WriteLine();
                    Console.Write("Play again? Y/N ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        tryagain = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks for playing, goodbye!");
                        tryagain = false;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, {0} is not an Armstrong number.", B);
                    Console.WriteLine();
                    Console.Write("Try again? y/n ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        tryagain = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks for playing, goodbye!");
                        tryagain = false;
                    }
                }
            }
            

        }
    }
}

// 11. ABC Taxi Company has the following meter charges based on the kilometres travelled. 
// Minimum fixed charge: $2.40 
// In addition the fare would be computed at 40 cents per kilometer. 
// E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

// 12. In the ABC Taxi Company example above, print the output so that the fare is 
// the output is printed always rounded to nearest 10 cents and printed to two decimal places.

//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter distance travelled: ");
//            decimal x = Convert.ToDecimal(Console.ReadLine());
//            decimal fare = (decimal)2.4 + x * (decimal)0.4;
//            decimal fare1 = Math.Round(fare, 2);
//            Console.WriteLine("Your taxi fare for this journey: {0:c2}", fare);
//        }
//    }
//}

//// 10. Write a program that reads the (x,y) coordinates of two points. 
//// Compute the distance between the two points using the formula: 
//// Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]
//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter x coordinate of point 1: ");
//            double x1 = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Enter y coordinate of point 1: ");
//            double y1 = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Enter x coordinate of point 2: ");
//            double x2 = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Enter y coordinate of point 2: ");
//            double y2 = Convert.ToDouble(Console.ReadLine());

//            double z = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//            decimal z1 = Convert.ToDecimal(z);
//            z1 = Math.Round(z1, 2);
//            Console.WriteLine($"The distance between Points 1 and 2 is {z1}.");

//        }
//    }
//}

//// 7. The ABC Company pays its employees salary plus benefits. 
//// The benefits are calculated as a percentage of the salary. 
//// The company pays every employee 10% housing allowance and 3% transport allowance. 
//// Write a program that takes the salary as input and prints the total income 
//// (salary + housing allowance + transport allowance) as output. Format the output in currency format.

//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter your salary: ");
//            double sal = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine();
//            Console.WriteLine("Salary Breakdown");
//            Console.WriteLine("------------------------------------------------");
//            Console.WriteLine("\tSalary: \t\t {0:c}", sal);
//            Console.WriteLine("\tHousing Allowance: \t {0:c}", sal * 0.1);
//            Console.WriteLine("\tTransport Allowance: \t {0:c}", sal * 0.03);
//        }
//    }
//}

// 5. Write a program that takes a double precision number as input and prints the square root of the number. 
// The square root should be rounded to 3 decimal places. 

//namespace CSPractices
//{ 
//    class Program
//    {
//        public static void ReadDouble()
//        {
//            Console.Write("Please enter an integer: ");

//            string tested;

//            while (true)
//            {
//                tested = Console.ReadLine();

//                if (Int32.TryParse(tested, out int A))
//                {
//                    break;
//                }
//                else
//                {
//                Console.Write("You must enter an integer. Please try again: ");
//                }
//            }

//            int X = Convert.ToInt32(tested);
//            double X1 = Convert.ToDouble(X);
//            double Xroot = Math.Sqrt(X1);
//            decimal Xroot1 = Convert.ToDecimal(Xroot);
//            decimal Xrounded = Math.Round(Xroot1, 3);
//            Console.WriteLine($"For {X},");
//            Console.WriteLine($"its square root is {Xroot}");
//            Console.WriteLine($"which rounded to 3 decimal places, is {Xrounded}.");

//        }
//        static void Main(string[] args)
//        {
//            ReadDouble();
//        }
//    }
//}