using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            // assigning my arrays
            string[] stringArray = { "Taco", "Burger", "Pizza", "Pasta", "Seafood", "Sushi" };
            int[] intArray = { 1, 2, 3, 4, 5 };


            // letting the user choose from my string array
            Console.WriteLine("Pick a number 0-5 to decide what you will order tonight: ");
            int stringNum = Convert.ToInt32(Console.ReadLine());

            // if statement to produce error if they pick a number outside the range given
            if (stringNum > 5)
            {
                Console.WriteLine("You picked a number outside of the options provided for you.");
            }
            else
            {
                string food = stringArray[stringNum];
                Console.WriteLine("You choose: " + food + ".");

                // included inside else so they can continue with the same order and see how much they are going to order of the food they choose, allowing for errors 
                Console.WriteLine("Now choose how many of each you will order. Pick a number 0-4: ");
                int intNum = Convert.ToInt32(Console.ReadLine());


                if (intNum > 4)
                {
                    Console.WriteLine("You picked a number outside of the options provided for you.");
                }
                else
                {
                    Console.WriteLine("You will order " + intArray[intNum] + " of the " + food + ".");
                }
            }



            Console.ReadLine();

            //List<int> intList = new List<int>();

            //intList.Add(4);
            //intList.Add(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);

            //Console.ReadLine();
        }
    }
}
