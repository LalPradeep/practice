////////using System;
////////namespace Day1
////////{
////////    class Day1class
////////    {
////////        static void Main(string[] args)
////////        {
////////            Console.Write("Enter your name: ");
////////            string name = Console.ReadLine();
////////            Console.Write("Enter your age: ");
////////            int age = Convert.ToInt32(Console.ReadLine());
////////            Console.WriteLine("Hello, " + name + "!, You are " + age + " years old.");
////////        }
////////    }
////////}

//////Console.Write("Enter your age: ");
//////int age=Convert.ToInt32(Console.ReadLine());
//////if (age > 18)
//////{
//////    Console.WriteLine("You are eligible to vote.");
//////}
//////else
//////{
//////    Console.WriteLine("You are not eligible to vote.");
//////}

////Console.Write("Enter a number: ");
////int num = Convert.ToInt32(Console.ReadLine());
////if (num> 0)
////{
////    Console.WriteLine("The number is positive.");
////}
////else if (num < 0)
////{
////    Console.WriteLine("The number is negative.");
////}
////else
////{
////    Console.WriteLine("The number is zero.");
////}

//int num = 0;
//int s = 0;
//while (num <= 100)
//{
//    s=s+num;
//    num++;

//}
////Console.WriteLine(s);

//for (int i = 0; i < 100; i++)
//{
//    if (i % 2 != 0 && i != 0)
//    {
//        Console.Write(i+", ");
//        //}
//        //else if (i % 2 == 1)
//        //{
//        //    Console.Write("The odd numbers are" + i);
//        //}
//        //else
//        //{
//        //    Console.WriteLine("The number is zero");
//        //}
//    }
//}



using System;
namespace Day1
{
    class Day1class
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operator (+, -, *, /): ");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine("The sum is: " + (a + b));
            }
            else if (c == "-")
            {
                Console.WriteLine("The difference is: " + (a - b));
            }
            else if (c == "*")
            {
                Console.WriteLine("The product is: " + (a * b));
            }
            else if (c == "/")
            {
                if (b != 0)
                {
                    Console.WriteLine("The quotient is: " + (a / b));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }
        }
    }
}