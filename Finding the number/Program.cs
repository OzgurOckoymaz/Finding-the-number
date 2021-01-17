using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("you have 3 choices to guess the true number between 1 and 10.");
            Console.WriteLine("we will help you to guess finding the true number , like going above or below!");

            Random rnd = new Random();
            int ran_num = rnd.Next(1, 11);
            int counter = 1;

            while (counter <= 3)
            {
                Console.WriteLine($"Enter the {counter}. number");
                int guessed = Convert.ToInt32(Console.ReadLine());
                if (guessed > 1 && guessed <= 10)
                {
                    if (guessed == ran_num)
                    {
                        Console.WriteLine("Congrats!!!");
                        Console.WriteLine("***************");
                        Console.WriteLine("Will you play again? Y/N");
                        char select = Convert.ToChar(Console.ReadLine());
                        if (select == 'Y' || select == 'y')
                        {
                            counter = 0;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (guessed < ran_num)
                    {
                        Console.WriteLine("Enter bigger number!");
                    }
                    else
                    {
                        Console.WriteLine("Enter smaller number");
                    }
                }
                else
                {
                    Console.WriteLine("Please a valid value");
                    Console.WriteLine("Try again!");
                    counter = 0;
                }
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine("You have a bad day!");
                    Console.WriteLine("Will you try again? Y/N");
                    char trying = Convert.ToChar(Console.ReadLine());
                    if (trying == 'Y' || trying == 'y')
                    {
                        counter = 1;
                    }
                }
            }

        }
    }
}
