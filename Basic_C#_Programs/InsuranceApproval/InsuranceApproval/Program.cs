using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you approved for car insurance?");

            // collecting information from user
            Console.WriteLine("What is your age? Numbers only please.");
            string age = Console.ReadLine();
            int age_final = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Please answer \"True\" or \"False\".");
            string DUI = Console.ReadLine();
            bool DUI_answer = Convert.ToBoolean(DUI);

            Console.WriteLine("How many speeding tickets have you had? Numbers only please.");
            string ticket = Console.ReadLine();
            int ticket_final = Convert.ToInt32(ticket);


            // calculates if they qualify and prints to console
            bool result = (age_final > 15 && DUI_answer == false && ticket_final <= 3);
            if (result == true)
            {
                Console.WriteLine("Congrats! You qualify for car insurance.");
            }
            else
            {
                Console.WriteLine("You do not qualify for car insurance.");
            }


            Console.ReadLine();
        }
    }
}
