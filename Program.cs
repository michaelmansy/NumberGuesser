using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessor
{
    class Program
    {
        static void Main(string[] args)
        {
            getAppInfo();

            greetUser();

            //init corrdct number
            //int correctNumber = 7;


            while (true)
            {
                //create a random number
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //make sure the user enters an actual number
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message; enter a number 
                        printColorMessage(ConsoleColor.Red, "please use an actual number");

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //compare guess to correct number
                    if (guess != correctNumber)
                    {
                        //print error message; not the correct number 
                        printColorMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }
                }

                //success....correct number
                printColorMessage(ConsoleColor.Yellow, "CONGRATULATIONS.....You are CORRECT!!!");

                //ask user if they want to play again
                Console.WriteLine("Play Again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }else if(answer == "N")
                {
                    Console.WriteLine("GoodBye!");
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        //get and display app info
        static void getAppInfo()
        {
            //set up some vars for the app
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Michael Mansy";

            //change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //print out the app info in green color
            Console.WriteLine("{0}: Version is {1} made by {2}", appName, appVersion, appAuthor);

            //reset text color back to normal
            Console.ResetColor();
        }

        //welcome msg to users
        static void greetUser()
        {
            //ask the user for name
            Console.WriteLine("what is your name?");

            //get user input
            string inputName = Console.ReadLine();

            //welcome message to the user
            Console.WriteLine("Welcome {0} ,Let's play a game", inputName);

            //ask the user to guess a number
            Console.WriteLine("{0}, Would you please try and guess a number between 1 and 10", inputName);
        }

        //print color message
        static void printColorMessage(ConsoleColor color, string message)
        {
            //change text color 
            Console.ForegroundColor = color;

            //tell the user to enter a number
            Console.WriteLine(message);

            //reset text color back to normal
            Console.ResetColor();
        }
    }
}
