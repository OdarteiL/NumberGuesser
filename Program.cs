namespace NumberGuesser;

class Program
{
    static void Main(string[] args)
    {
        GetAppInfo();

        GreetUsers();

        while (true)
        {
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            int guess = 0;

            Console.WriteLine("Guess a Number from 1 to 10");

            while (guess != correctNumber)
            {
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                    continue;
                }

                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, Please try again");
                }
            }

            PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed right!");

            Console.WriteLine("Want to play again? [Y or N]");

            string? answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Thanks for playing");
                return;
            }

        }
    }

    static void GetAppInfo()
    {
        var appName = "Number Guesser";
        var appVersion = "1.0.0";
        var appAuthor = "Odartei Lamptey";

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

        Console.ResetColor();
    }

    static void GreetUsers()
    {
        string? nameInput = null;
        while (string.IsNullOrWhiteSpace(nameInput))
        {
            Console.WriteLine("What is your Name?");
            nameInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameInput))
            {
                Console.WriteLine("No name provided ... Pls provide a Name :)");
            }
        }
        Console.WriteLine($"Hello {nameInput}! Let's play a game ...");
    }

    static void PrintColorMessage(ConsoleColor color, string message)
    {
        Console.ForegroundColor = color;

        Console.WriteLine(message);

        Console.ResetColor();
    }
}