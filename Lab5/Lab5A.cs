/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Assignment#: Lab5A
*/

using System;

namespace Lab5
{
    class Lab5A
    {
        static void Main(string[] args)
        {
            string uI;
            char input;
            bool isYes;

            Console.Write("Do you have a driving permit (Y/N)? ");
            uI = Console.ReadLine();

            input = Convert.ToChar(uI);

            //legacy statement to determine if user inputs Y or Y for yes or N or n for no
            isYes = (input == 'Y' | input == 'y' ? true : false);
            isYes = (input == 'N' | input == 'n' ? false : true); 

            // user inputs Y or y
            if (isYes == true)
            {
                Console.Write("Do you have a commercial driving license (Y/N)? ");
                uI = Console.ReadLine();

                input = Convert.ToChar(uI);

                //legacy statement to determine if user inputs Y or Y for yes or N or n for no
                isYes = (input == 'Y' | input == 'y' ? true : false);
                isYes = (input == 'N' | input == 'n' ? false : true);

                // user inputs Y or y
                if (isYes == true)
                    Console.WriteLine("Congratulations! You can purchase a vehicle, let’s start talking options! ");
                else
                    Console.WriteLine("Commercial driving license is a prerequisite to purchase a vehicle! ");
            }
            else
                Console.WriteLine("Driving permit is a prerequisite to purchase a vehicle!  ");
        }
    }
}
