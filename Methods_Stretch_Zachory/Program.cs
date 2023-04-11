using System;

namespace Methods_Stretch_Zachory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Has the user input two whole numbers.
            Console.WriteLine("Please enter a whole number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number.");
            int y = Convert.ToInt32(Console.ReadLine());

            //Multiplies the two numbers that the user has chosen.
            Console.WriteLine(Multiply(x, y));

            //Asks the user for their name.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            
            WelcomeUser(name);

            Goodbye();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void WelcomeUser(string username)
        {
            //Greets the user.
            Console.WriteLine($"Hello, {username}.It is nice to meet you.");
        }

        /// <summary>
        /// Prints a goodbye message to the console.
        /// </summary>
        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day.");
        }
    }
}
