using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine($"What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);


        int guess = 0;
        int numGuesses = 0;

        while (guess != magicNumber)
        {Console.WriteLine(" What is your guess?");
        guess = int.Parse(Console.ReadLine());
        numGuesses++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Lower!");

            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            Console.WriteLine($"Number of guesses: {numGuesses}");
            
        
        }



    }
}