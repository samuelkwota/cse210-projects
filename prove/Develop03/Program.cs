using System;

public class PromptGenerator
{
    public string GeneratePrompt()
    {
        // Generate a random number between 1 and 10
        Random random = new Random();
        int randomNumber = random.Next(1, 11);

        // Check if the random number is even
        if (randomNumber % 2 == 0)
        {
            return "Please enter your name: ";
        }
        else
        {
            return "What is your favorite color? ";
        }
    }
}

class Program
{
    static void Main()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GeneratePrompt();

        Console.WriteLine(prompt);
    }
}