using System;

namespace NumberGuesser
{
    //MainClass
    class Program
    {
        //EntryPoint
        static void Main(string[] args)
        {

            GetAppInfo(); //Run GetAppInfo function

            GreetUser(); //Run GreetUser function

            while (true)
            {
                //Create a random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 20);

                //init Guess number
                int guess = 0;

                //Ask user for guess number
                Console.WriteLine("Guess a number between 0 to 20");

                //Logic
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print Error Message
                        PrintColorMessage(ConsoleColor.DarkRed, "Please enter an actual number!");

                        //Keep Going
                        continue;
                    }

                    //Cast to int input
                    guess = Int32.Parse(input);

                    //Match Guess to Correct number
                    if (guess != correctNumber)
                    {
                        //Print Error Message
                        PrintColorMessage(ConsoleColor.DarkRed, "Wrong number, Please try again!");
                    }
                }
                //Print Success message
                PrintColorMessage(ConsoleColor.DarkYellow, "Congratulations! You guessed the right number!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Setup variables
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dhruv Bhatt";

            //Change TextColor
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Write AppInfo
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask User's name
            Console.WriteLine("What is your name?");

            //Take Input
            string inputName = Console.ReadLine();

            //Greetings
            Console.WriteLine("Hello {0}, Let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change TextColor
            Console.ForegroundColor = color;

            //Wrong number message
            Console.WriteLine(message);

            //Reset Color
            Console.ResetColor();
        }
    }
}