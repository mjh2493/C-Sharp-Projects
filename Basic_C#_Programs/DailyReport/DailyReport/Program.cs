using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // asks for name and repeats it back
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");


            // tells them what course they are on
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("You are on the " + course + " course.");


            // says what page they are on
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt32(page);
            Console.WriteLine("You are on page " + pageNum + ".");


            // uses an if statement to let them know if an instructor will reach out
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string help = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(help);
            if (helpBool == true)
            {
                Console.WriteLine("We will reach out to help.");
            }
            else
            {
                Console.WriteLine("Great, we are glad to hear it!");
            }

            // allows them to share their experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Thanks for sharing!");


            // allows them to share feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thanks for sharing!");

            // congrats them on their hours studied
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hourFinal = Convert.ToInt32(hours);
            Console.WriteLine("Great work on putting in " + hourFinal + " hours of studying!");

            // final message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");


            Console.ReadLine();





        }
    }
}
