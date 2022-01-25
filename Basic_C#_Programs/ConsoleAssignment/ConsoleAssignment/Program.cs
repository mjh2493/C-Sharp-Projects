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
            Console.WriteLine("Type in a random meal you would order from a restaurant to combine it with the food from our list: ");
            string randomFood = Console.ReadLine();

            // loop to add random word to end of each item in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += (" " + randomFood);
                Console.WriteLine(stringArray[i]);
            }

            // part three- adds a <= to the loop iteration
            string[] stringArray2 = { "Taco", "Burger", "Pizza", "Pasta", "Seafood", "Sushi" };

            Console.WriteLine("Type in a random meal you would order from a restaurant to combine it with the food from our list: ");
            string randomFood2 = Console.ReadLine();

            // loop to add random word to end of each item in the array
            for (int i = 0; i <= stringArray2.Length - 1; i++)
            {
                stringArray2[i] += (" " + randomFood2);
                Console.WriteLine(stringArray2[i]);
            }



            // part 4
            List<string> foodList = new List<string>() { "Taco", "Burger", "Pizza", "Pasta", "Seafood", "Sushi" };

            // takes in user input
            Console.WriteLine("Guess which meal we are thinking of. Each meal is only one word.");
            string foodGuess = Console.ReadLine();
            int indexNum = foodList.IndexOf(foodGuess);
            bool foodFalse = false;

            // if user guess is in the list, it iterates through and gives the index number

            for (int i=0; i< foodList.Count; i++)
            {

                if (foodList[i] == foodGuess)
                {
                    foodFalse = true;
                    i += foodList.Count;
                }
            }
            if (foodFalse == true) {
                Console.WriteLine(indexNum);
            }
            else
            {
                Console.WriteLine("You did not guess correctly.");
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
            // creates a list and an empty list
            List<string> foodList3 = new List<string>() { "Taco", "Burger", "Pizza", "Taco", "Pasta", "Seafood", "Sushi", "Burger" };
            List<string> newFood = new List<string>();
            // adds first item and prints a message that it has not been seen to start off the for loop
            newFood.Add(foodList3[0]);
            Console.WriteLine(foodList3[0] + " has not been seen before.");

            for (int i= 1; i < foodList3.Count; i++)
            {
                // looks for duplicates, if there are some it adds it to the list. if not, it adds in the item saying it is not a duplicate
                bool foodDup = false;
                foreach (string food in newFood)
                {
                    if (foodList3[i] == food)
                    {
                        Console.WriteLine(foodList3[i] + " has already been seen.");
                        foodDup = true;
                    }
                }
                if (foodDup == false)
                {
                    newFood.Add(foodList3[i]);
                    Console.WriteLine(foodList3[i] + " has not been seen before.");
                }
            }

           

            Console.ReadLine();
        }
    }
}
