using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer value between 1 and 100: ");

            try
            {
                string input = Console.ReadLine();

                int number = int.Parse(input); ;

                if ((number > 0) && (number <=100))
                {
                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine("You have entered " + number +
                         ". This is the current integer value in the loop: " + i.ToString());
                       
                    }

                    if (number%2 ==0)
                    {
                        Console.WriteLine("The number you entered is even!");
                    }
                    else
                    {
                        Console.WriteLine("The number you entered is odd!");
                    }

                    Console.WriteLine("Press any key to exit the program...");
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100.");
                    Console.WriteLine("press any key to exit the program and try again...");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 100");
                Console.WriteLine("Press any key to exit and try again");
            }
        }
    }
}
