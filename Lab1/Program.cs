using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, height;
            bool cont = true;

            while (cont)
            {
                string again;
                Console.WriteLine("Welcome to the room calculator.");
                Console.WriteLine("Please enter the lenth of one side of the room in decimal form.");
                side1 = (double.Parse(Console.ReadLine()));

                Console.WriteLine("Please enter the lenth of the adjacent side of the room in decimal form.");
                side2 = (double.Parse(Console.ReadLine()));

                Console.WriteLine("Please enter the height of the room in decimal form.");
                height = (double.Parse(Console.ReadLine()));

                Console.WriteLine("The area of the room is {0}.", (side1 * side2));
                Console.WriteLine("The perimeter of the room is {0}.", ((2 * side1) + (2 * side2)));
                Console.WriteLine("The volume of the room is {0}.", (side1*side2*height));

                Console.WriteLine("Would you like to try again? (Y/N)");
                again = Console.ReadLine();

                if (again == "y" || again == "Y")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                }
            }
        }
    }
}
