using System;

class Program
{
    static void Main(string[] args)
    {
        
        
     Console.WriteLine("What is your magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }  
    }
}