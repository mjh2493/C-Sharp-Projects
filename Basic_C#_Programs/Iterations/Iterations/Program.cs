using System;
using System.Collections.Generic;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i=0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test scores: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Mallory", "Mike", "Waffle" };

            //for (int j=0; j < names.Length; j++)
            //{
            //        Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();

            //testScores.Add(98);
            //testScores.Add(95);
            //testScores.Add(91);
            //testScores.Add(54);
            //testScores.Add(67);
            //testScores.Add(87);
            //testScores.Add(83);
            //testScores.Add(91);

            //foreach (int score in testScores)
            //{
            //    if (score>85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Mallory", "Mike", "Waffle" };

            //foreach (string name in names)
            //{

            //        Console.WriteLine(name);
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
