using System;

namespace lab_3_dice_roll_finished
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int roll;
            string userResponse = "y";

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            while (userResponse == "y")
            {
                Console.WriteLine($"Hello {userName} Please choose a number between 1-100");
                roll = int.Parse(Console.ReadLine());

                if (roll % 2 == 0)
                {
                    if (roll >= 2 && roll <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (roll >= 25 && roll <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (roll > 60)
                    {
                        Console.WriteLine($"{roll} Even");
                    }
                }
                else
                {
                    Console.WriteLine($"{roll} Odd");
                }

                Console.WriteLine($"Would you like to continue? {userName} y/n ");
                userResponse = Console.ReadLine();
            }
            Console.WriteLine($"Goodbye! {userName}");
        }
    }
}
