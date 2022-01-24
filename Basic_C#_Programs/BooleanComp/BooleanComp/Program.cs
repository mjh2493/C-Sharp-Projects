using System;

namespace BooleanComp
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking user to guess my favorite food and labeling that food as sushi
            Console.WriteLine("Guess my favorite food: ");
            string food = Console.ReadLine();
            bool ifGuessed = food == "sushi";


            // this allows for the while loop to run until my favorite food is guessed
            do
            {
                switch (food) // adding a few other favorite foods for commentary and then adding in the default statement and correct statement
                {
                    case "waffles":
                        Console.WriteLine("I do love waffles, but this is wrong. Guess again!");
                        Console.WriteLine("Guess my favorite food: ");
                        food = Console.ReadLine();
                        break;
                    case "steak":
                        Console.WriteLine("A good steak is the best, but this is not correct. Guess again!");
                        Console.WriteLine("Guess my favorite food: ");
                        food = Console.ReadLine();
                        break;
                    case "strawberries":
                        Console.WriteLine("Strawberries are delicious, but not quite my favorite. Guess again!");
                        Console.WriteLine("Guess my favorite food: ");
                        food = Console.ReadLine();
                        break;
                    case "sushi":
                        Console.WriteLine("You got it! I love sushi, especially living in NYC!");
                        ifGuessed = true;
                        break;
                    default:
                        Console.WriteLine("This is not right. Guess again!");
                        Console.WriteLine("Guess my favorite food: ");
                        food = Console.ReadLine();
                        break;
                }
            }

            while (!ifGuessed); // while loop runs while the answer is not sushi


            Console.WriteLine("What is my favorite type of sushi?");
            string sushi = Console.ReadLine();
            bool sushiType = sushi == "Philadelphia Roll";

            while (!sushiType)
            {
                switch(sushi)
                {
                    case "California Roll":
                        Console.WriteLine("I do like this roll, but it is not my favorite.");
                        Console.WriteLine("What is my favorite type of sushi?");
                        sushi = Console.ReadLine();
                        break;
                    case "Tuna Roll":
                        Console.WriteLine("I do not like a tuna roll.");
                        Console.WriteLine("What is my favorite type of sushi?");
                        sushi = Console.ReadLine();
                        break;
                    case "Philadelphia Roll":
                        Console.WriteLine("Good guess! Philadelphia Roll is my favorite.");

                        sushiType = true;
                        break;
                    default:
                        Console.WriteLine("This is not correct.");
                        Console.WriteLine("What is my favorite type of sushi?");
                        sushi = Console.ReadLine();
                        break;
                }
            }

            Console.Read();

        }
    }
}
