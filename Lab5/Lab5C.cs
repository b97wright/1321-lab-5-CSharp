/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Assignment#: Lab5C
*/

using System;

namespace Lab5
{
    class Lab5C
    {
        static void Main(string[] args)
        {
            string uI;
            int number1, number2;
            bool isXP, isYP;

            Console.Write("Enter x: ");
            uI = Console.ReadLine();

            number1 = Convert.ToInt32(uI);

            //legacy statement to determine if user inputs positive x
            isXP = (number1 >= 0 ? true : false);

            Console.Write("Enter y: ");
            uI = Console.ReadLine();

            number2 = Convert.ToInt32(uI);

            //legacy statement to determine if user inputs positive x
            isYP = (number2 >= 0 ? true : false);

            if (number1 == 0 && number2 == 0)
                Console.WriteLine("This point is on the origin. ");
            else if (number1 > 0 | number1 < 0 && number2 == 0)
                Console.WriteLine("This point is on the x axis. ");
            else if (number1 == 0 && number2 > 0 | number2 < 0)
                Console.WriteLine("This point is on the y axis. ");
            else if (isXP == true && isYP == true)
                Console.WriteLine("This point is in the first quadrant. ");
            else if (isXP == false && isYP == true)
                Console.WriteLine("This point is in the second quadrant. ");
            else if (isXP == false && isYP == false)
                Console.WriteLine("This point is in the third quadrant. ");
            else if (isXP == true && isYP == false)
                Console.WriteLine("This point is in the fourth quadrant. ");
            else
                Console.WriteLine("Invalid Inpu  ");



        }
    }
}
