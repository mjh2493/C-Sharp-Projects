using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // this takes in person 1's information
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            string per1rate = Console.ReadLine();
            int person1rate = Convert.ToInt32(per1rate);
            Console.WriteLine("Hours worked per week: ");
            string per1hours= Console.ReadLine();
            int person1hours = Convert.ToInt32(per1hours);
            int totalweeks1 = person1hours * 52; // 52 weeks in a year so have to calculate this before rate
            int totalsalary = totalweeks1 * person1rate;
            Console.WriteLine("Annual Salary of Person 1: " + totalsalary);
         
            // this takes in person 2's information
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            string per2rate = Console.ReadLine();
            int person2rate = Convert.ToInt32(per2rate);
            Console.WriteLine("Hours worked per week: ");
            string per2hours = Console.ReadLine();
            int person2hours = Convert.ToInt32(per2hours);
            int totalweeks2 = person2hours * 52; // 52 weeks in a year so have to calculate this before rate
            int totalsalary2 = totalweeks2 * person2rate;
            Console.WriteLine("Annual Salary of Person 1: " + totalsalary2);

            // this compares both of their annual salaries
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salarycom = totalsalary > totalsalary2;
            Console.WriteLine(salarycom);


            Console.ReadLine();
        }
    }
}
