/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Assignment#: Lab5B
*/

using System;

namespace Lab5
{
    class Lab5B
    {
        static void Main(string[] args)
        {
            string uI;
            int number;
            bool is2, is3, is5;

            Console.Write("Enter an integer: ");
            uI = Console.ReadLine();

            number = Convert.ToInt32(uI);

            //legacy statement to determine if user inputs s divisible is 2, 3, or 5
            is2 = (number % 2 == 0 ? true : false);
            is3 = (number % 3 == 0 ? true : false);
            is5 = (number % 5 == 0 ? true : false);

            // user inputs Y or y
            if (is2 == true)
                Console.WriteLine("This number is divisible by 2 ");
            else if (is3 == true)
                Console.WriteLine("This number is divisible by 3 ");
            else if (is5 == true)
                Console.WriteLine("This number is divisible by 5 ");
            else
                Console.WriteLine("This number is undetermined ");
        }
    }
}
