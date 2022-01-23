using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // asks for package weight
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // starts the first if statement
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }

            // if under 50, the else will continue asking questions to determine final price
            else
            {
                Console.WriteLine("You may continue. Please enter width below.");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter height below: ");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the length below: ");
                int length = Convert.ToInt32(Console.ReadLine());

                // final embedded if statement to determine if the package dimensions are too big. else will continue to calculate final price.
                if (width > 50 || height > 50 || length > 50)
                {
                    Console.WriteLine("Your pacakge is too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    int total = width * height * length;
                    int final_total = total * weight;
                    decimal price = final_total / 100;
                    Console.WriteLine("Your final price is: $" + price);
                    Console.ReadLine();
                }

            }

        }
    }
}
