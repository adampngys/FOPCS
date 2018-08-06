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

//// 19. ABC Taxi Company has the following meter charges based on the kilometres travelled.
//// Minimum charge: $2.40 (first 0.5 km no additional charges apply)
//// For the next 8.5 kms the rate is 4 cents for every 100 meters
//// After that: 5 cents for evey 100 meters
//// In the above example you should assume that the meter falls every 100 meters.So assume that 
//// if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:
//// $ 2.40 (first 0.5 km) +
//// $ 85 * 0.04 (next 8.5 km) +
//// $ (122 -90) * 0.05 (for distance over 9.0 km)
//// = $7.40

//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter the distance of the journey in km: ");
//            double distance = Convert.ToDouble(Console.ReadLine());
//            double distance1 = (Math.Ceiling(distance * 10)) / 10;
//            Console.WriteLine();
//            Console.WriteLine("You travelled {0} km.", distance1);
//            Console.WriteLine();
//            Console.WriteLine("\tTaxi Fare");
//            double price1 = 2.4;
//            Console.WriteLine("-----------------------------");
//            Console.WriteLine("\tFirst 0.5 km = {0:c}", price1);
//            double price2 = 85 * 0.04;
//            Console.WriteLine("\tNext 8.5 km = {0:c}", price2);
//            double price3 = (distance1 * 10 - 90) * 0.05;
//            Console.WriteLine("\tAbove 9 km = {0:c}", price3);
//            Console.WriteLine("-----------------------------");
//            double price4 = price1 + price2 + price3;
//            Console.WriteLine("\tTOTAL = {0:c}", price4);
//        }
//    }
//}

//// 18. Write a program that would compute the grade for a mark that the student gets. 
//// The program should take an integer number between 0 and 100 and print the following:
//// You scored 73 marks which is B grade.where 73 is the input and B is calculated by the program. 
//// Use the following table for computing the grades:

//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter your grade: ");
//            double GRADE = Convert.ToDouble(Console.ReadLine());

//            if (GRADE < 0 || GRADE > 100)
//            {
//                Console.WriteLine("**Error**");
//            }
//            else
//            {
//                if(GRADE > 0 && GRADE < 40)
//                {
//                    Console.WriteLine("Your grade is F.");
//                }
//                else if (GRADE > 40 && GRADE < 59)
//                {
//                    Console.WriteLine("Your grade is C.");
//                }
//                else if (GRADE > 60 && GRADE < 79)
//                {
//                    Console.WriteLine("Your grade is B.");
//                }
//                else 
//                {
//                    Console.WriteLine("Your grade is A.");
//                }
//            }

//        }
//    }
//}

//// 17. Write a program that would request for your name, gender and age and would print a greeting like 
//// this: Good morning Uncle Sam ( if Sam, M, 45 is entered) 
//// (any gentlemen 40 years or more is Uncle any lady 40 years or more is Aunty, 
//// if less than forty they become just Mr or Ms. as the case may be.)
//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter your name: ");
//            string NAME = Console.ReadLine();
//            Console.Write("Please enter your gender (M/F): ");
//            string GENDER = (Console.ReadLine()).ToLower();
//            Console.Write("Please enter your age: ");
//            int AGE = Convert.ToInt32(Console.ReadLine());

//            if(GENDER == "m")
//            {
//                if(AGE >=40)
//                {
//                    Console.WriteLine("Hi, Uncle {0}.", NAME);
//                }
//                else
//                {
//                    Console.WriteLine("Hi, Mr. {0}.", NAME);
//                }

//            }
//            else
//            {
//                if (AGE >= 40)
//                {
//                    Console.WriteLine("Hi, Auntie {0}.", NAME);
//                }
//                else
//                {
//                    Console.WriteLine("Hi, Ms. {0}.", NAME);
//                }
//            }
//        }
//    }
//}

//// 16. Write a program that would request for your name and gender (M or F assume capital letter) and 
//// print a greeting like this: Good Morning Mr. Venkat where you entered Venkat for name and M for gender.

//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter your name: ");
//            string NAME = Console.ReadLine();
//            Console.Write("Please enter your gender (M/F): ");
//            string GENDER = (Console.ReadLine()).ToLower();

//            if (GENDER == "m")
//            {
//                Console.WriteLine($"Good Morning, Mr. {NAME}!");
//            }
//            else
//            {
//                Console.WriteLine($"Good Morning, Ms. {NAME}!");
//            }
//        }
//    }
//}

//// 15. Given a three-digit integer as input write a C# program to determine whether the number is an Armstrong number. 
//// An Armstrong number is one for which the sum of each digit raised to the power of number of digits results 
//// in the number itself.
//// For a three digit number 153 = 13 + 53 + 33
//// None confine to 3 digit examples only ie., number values 100…999.
//// Minor comment change
//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool tryagain = true;

//            while (tryagain)
//            {
//                Console.Write("Please enter a three-digit integer: ");

//                string input;

//                while (true)
//                {
//                    input = Console.ReadLine();

//                    if (Int32.TryParse(input, out int A) && Regex.IsMatch(input, @"^[0-9]{3}$"))
//                    {
//                        break;
//                    }
//                    else
//                    {
//                        Console.Write("Please just enter a three-digit integer: ");
//                    }
//                }

//                Console.WriteLine();
//                int B = Convert.ToInt32(input);
//                Console.WriteLine($"You've entered {B}.");

//                // 3-digit integer XYZ has Z as first digit (position or power 0), 
//                // Y as second digit (position or power 1) 
//                // and X as third digit (position or power 2)
//                int firstdigit = (int)((B / Math.Pow(10, 0)) % 10);
//                int seconddigit = (int)((B / Math.Pow(10, 1)) % 10);
//                int thirddigit = (int)((B / Math.Pow(10, 2)) % 10);

//                Console.WriteLine($"In the ONES place is {firstdigit}.");
//                Console.WriteLine($"In the TENS place is {seconddigit}.");
//                Console.WriteLine($"In the HUNDREDS place is {thirddigit}.");
//                Console.WriteLine();
//                Console.Write("Is {0} an Armstrong number?", B);
//                Console.WriteLine(" i.e. Is {0} = {1}^3 + {2}^3 + {3}^3 ?", B, thirddigit, seconddigit, firstdigit);
//                Console.WriteLine();
//                double third = Math.Pow((double)thirddigit, 3);
//                double second = Math.Pow((double)seconddigit, 3);
//                double first = Math.Pow((double)firstdigit, 3);
//                double sum = first + second + third;
//                Console.WriteLine("\t{0}^3 = {1}", thirddigit, third);
//                Console.WriteLine("\t{0}^3 = {1}", seconddigit, second);
//                Console.WriteLine("\t{0}^3 = {1}", firstdigit, first);
//                Console.WriteLine("-----------------------");
//                Console.WriteLine("\tSUM = {0}", sum);
//                Console.WriteLine();
//                if ((int)sum == B)
//                {
//                    Console.WriteLine("{0} is an Armstrong number!", B);
//                    Console.WriteLine();
//                    Console.Write("Play again? Y/N ");
//                    string answer = Console.ReadLine();
//                    if (answer.ToLower() == "y")
//                    {
//                        tryagain = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine();
//                        Console.WriteLine("Thanks for playing, goodbye!\n");
//                        tryagain = false;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Sorry, {0} is not an Armstrong number.", B);
//                    Console.WriteLine();
//                    Console.Write("Try again? y/n ");
//                    string answer = Console.ReadLine();
//                    if (answer.ToLower() == "y")
//                    {
//                        tryagain = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine();
//                        Console.WriteLine("Thanks for playing, goodbye!");
//                        tryagain = false;
//                    }
//                }
//            }


//        }
//    }
//}

//// 14. Consider the simple Geometric example of determining the area of a triangle, 
//// given the lengths of its three sides a, b and c.
//// Use the formula: AREA = SQUAREROOT[s(s - a)(s - b)(s - c)] where s = (a+b+c) / 2
//// Does your program always work? If not alter it to consider situations fro which it fails.

//namespace CSPractices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool again = true;
//            while(again)
//            {
//                Console.Write("Enter value of a: ");
//                double a = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Enter value of b: ");
//                double b = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Enter value of c: ");
//                double c = Convert.ToDouble(Console.ReadLine());

//                double s = (a + b + c) / 2;
//                double s1 = s - a;
//                double s2 = s - b;
//                double s3 = s - c;
//                double s4 = s * s1 * s2 * s3;
//                double Area = Math.Round(Math.Sqrt(s4), 2);

//                Console.WriteLine($"Area = {Area}");
//                Console.WriteLine("");
//                //if(double.IsNaN(Area))
//                //{
//                //    Console.WriteLine("Not a number! Try again!");
//                //    again = true;
//                //}
//                Console.WriteLine("Try again? y/n ");
//                string reply = Console.ReadLine();
//                reply.ToLower();
//                if(reply == "y")
//                {
//                    again = true;
//                }
//                else
//                {
//                    Console.WriteLine("Thanks for playing.");
//                    again = false;
//                }
//            }

//        }
//    }
//}



//// 11. ABC Taxi Company has the following meter charges based on the kilometres travelled. 
//// Minimum fixed charge: $2.40 
//// In addition the fare would be computed at 40 cents per kilometer. 
//// E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

//// 12. In the ABC Taxi Company example above, print the output so that the fare is 
//// the output is printed always rounded to nearest 10 cents and printed to two decimal places.

//// 13. In the above problem, if you have always to round upwards – how would you do that?

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
//            Console.WriteLine("Your taxi fare for this journey: {0:c2}", fare1);
//            decimal fare2 = (Math.Ceiling(fare * 10) / 10);
//            Console.WriteLine("Your taxi fare for this journey: {0:c2}", fare2);
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