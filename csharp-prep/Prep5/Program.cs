using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        DisplayWelcome();

        // Prompt user for name
        string userName = PromptUserName();

        // Prompt user for favorite number
        int userNumber = PromptUserNumber();

        // Calculate square of the user's number
        int squaredNumber = SquareNumber(userNumber);

        // Display result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt user for name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt user for favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! Your favorite number squared is: {squaredNumber}");
    }
}
