using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // parts 1-3
            // creates an array
            string[] stringArray = { "Taco", "Burger", "Pizza", "Pasta", "Seafood", "Sushi" };

            // input to add to end of each item in array
            Console.WriteLine("Type in a random meal you would order from a restaurant: ");
            string randomFood = Console.ReadLine();

            // loop to add random word to end of each item in the array
            for (int i = 0; i <= stringArray.Length; i++)
            {
                stringArray[i] += (" " + randomFood);
                Console.WriteLine(stringArray[i]);
            }



            // part 4
            List<string> foodList = new List<string>() { "Taco", "Burger", "Pizza", "Pasta", "Seafood", "Sushi" };

            // takes in user input
            Console.WriteLine("Guess which meal we are thinking of. Each meal is only one word.");
            string foodGuess = Console.ReadLine();
            int indexNum = foodList.IndexOf(foodGuess);

            // if user guess is in the list, it iterates through and gives the index number
            if (foodList.Contains(foodGuess))
            {
                foreach (string food in foodList)
                {
                    if (food == foodGuess)
                    {
                        Console.WriteLine(foodList.IndexOf(food));
                    }
                }
            }
            // if user guess is not on the list, they get an error message
            else
            {
                Console.WriteLine("You guessed wrong!");
            }

            // part 5
            List<string> foodList2 = new List<string>() { "Taco", "Burger", "Pizza", "Taco", "Pasta", "Seafood", "Sushi" };

            // has user input a guess
            Console.WriteLine("Guess which meal we are thinking of. Each meal is only one word.");
            string foodGuess2 = Console.ReadLine();

            // if user guess is in the list, it iterates through and gives all the index numbers, even if item repeats
            if (foodList2.Contains(foodGuess2))
            {
                for (int i = 0; i < foodList2.Count; i++)
                {
                    if (foodList2[i] == foodGuess2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            // if user guess is not on the list, they get an error message
            else
            {
                Console.WriteLine("You did not guess correctly!");
            }

            // part6
            List<string> foodList3 = new List<string>() { "Taco", "Burger", "Pizza", "Taco", "Pasta", "Seafood", "Sushi", "Burger" };

            // creates a list showing only the unique values
            var unique = foodList3.Distinct();

            Console.WriteLine("This is a list of unique values: ");
            foreach (string food in unique)
            {
                Console.WriteLine(food);
            }


            // creates a list with just the duplicates
            var duplicates = foodList3
                    .GroupBy(i => i)
                    .Where(g => g.Count() > 1)
                    .Select(y => y.Key);

            Console.WriteLine("From the list above, these are the duplicates: ");
            foreach (string food in duplicates)
            {
                Console.WriteLine(food);
            }

            Console.ReadLine();
        }
    }
}
