using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {


            int max = 100;


   

            bool diffSel = true;
            while (diffSel)
            {

                Console.WriteLine("Please select difficulty:");
                Console.WriteLine("1 - 100");
                Console.WriteLine("2 - 1000");
                Console.WriteLine("3 - 100000");
                Console.WriteLine("4 - Custom Number");
                Console.WriteLine();
                Console.Write("Your choice: ");
                string diff = Console.ReadLine();
                switch (diff)
                {
                    case "1":
                        max = 100;
                        diffSel = false;
                        break;
                    case "2":
                        max = 1000;
                        diffSel = false;

                        break;
                    case "3":
                        max = 100000;
                        diffSel = false;

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Please select any number (32 bit limit)");
                        Console.WriteLine();
                        Console.Write("Your Number: ");
                        bool validNumber = true;
                        while (validNumber)
                        {
                            string str = Console.ReadLine();
                            if (Int32.TryParse(str, out max))
                            {
                                validNumber = false;
                            }
                            Console.Clear();
                            Console.WriteLine("Invalid number. please try again");
                            Console.WriteLine();
                            Console.Write("Your Number: ");

  

                        }
                        diffSel = false;


                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option. Please try again");
                        Console.WriteLine();
                        break;
                }

            }

            //Number has been sucessfully chosen. Now start game
            Console.Clear();

            Random rnd = new Random();
            int number = rnd.Next(1, max);


            Console.Clear();
            bool gameRunning = true;
            while (gameRunning)
            {
                
                //Console.WriteLine("DEBUG: Random number = " + number);
                Console.WriteLine("Guess a number between 1 and " + max);
                Console.WriteLine();
                Console.Write("Your guess: ");

                string guess = Console.ReadLine();
                int intGuess;
                if (Int32.TryParse(guess, out intGuess))
                {

                    if (intGuess == number)
                    {
                        gameRunning = false;
                    }

                    if (intGuess < number)
                    {
                        Console.Clear();
                        Console.WriteLine("Last guess (" + intGuess + ") was too LOW!");
                    }

                    if (intGuess > number)
                    {
                        Console.Clear();
                        Console.WriteLine("Last guess (" + intGuess + ") was too HIGH!");
                    }
                    if (intGuess > max)
                    {
                        Console.Clear();
                        Console.WriteLine("You stupid? That number is higher than the max number... Try again");
                    }


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid guess");
                }


                
            }
            Console.Clear();
            Console.WriteLine("Congrats you won");
            Console.WriteLine("Press any key to exit");

            Console.ReadKey();



        }
    }
}
