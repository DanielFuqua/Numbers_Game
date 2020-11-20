using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run get app info function

            GreetUser(); // Ask for users name and greet

            while (true)
            {

            

            // Init corrct number
            //int correctNumber = 7;

            // Create a new random object
            Random random = new Random();

            // Init correct number
            int correctNumber = random.Next(1, 10);

            // Init gues var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                //MAke sure input is a number
                if(!int.TryParse(input, out guess))
                {
                    // Print error message
                    PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                    // Keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // MAtch guesss to correct number
                if(guess != correctNumber)
                {
                     // Reset text color
                    Console.ResetColor();
                    
                    //Print error message
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                 }
            }

                // Output success message 

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");

                // Reset text color
                Console.ResetColor();


                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")

                {
                    return;
                }
                {
                    return;
                }
            }

        }

        // Get and display app info

        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Daniel Fuqua";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet 
        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game..", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }


    }
}
