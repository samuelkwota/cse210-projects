using System;
using System.Threading;

class MindfulnessProgram
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
           

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        StartBreathingActivity();
                        break;
                    case 2:
                        StartReflectingActivity();
                        break;
                    case 3:
                        StartListingActivity();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("");
                        Console.WriteLine("Goodbye, have a nice day!!");
                        Console.WriteLine("Samuek Kwota");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine();
        }
    }

    static void StartBreathingActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Breathing Activity.");
         Console.WriteLine("");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine("");
        Console.WriteLine("Be ready in 10 seconds.");
        Thread.Sleep(20000);
         Console.WriteLine("");
        Console.WriteLine("Breath in for 5 seconds.");
        Thread.Sleep(5000);
        Console.WriteLine("Now Breath out for 5 seconds.");
         Console.WriteLine("");
        Thread.Sleep(5000);
        Console.WriteLine("Breath in for 5 seconds.");
        Thread.Sleep(5000);
        Console.WriteLine("Now Breath out for 5 seconds.");
         Console.WriteLine("");
        Thread.Sleep(5000);
        Console.WriteLine("Breath in for 5 seconds.");
        Thread.Sleep(5000);
        Console.WriteLine("Now Breath out for 5 seconds.");
         Console.WriteLine("");
        Thread.Sleep(5000);
        Console.WriteLine("Well done!!.");
    }

    static void StartReflectingActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown and resilence.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspect of your life.");
        Console.WriteLine("");
        Console.WriteLine("Be ready in 10 seconds.");
        Thread.Sleep(20000);
        Console.WriteLine("");
        Console.WriteLine("Now, Close your eyes and focus on your thoughts and open your eyes after 10 seconds.");
        Console.WriteLine("");
        Thread.Sleep(20500);
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine("");
        Console.WriteLine("Think of a time when you did something really dificult in 60 seconds.");
        Thread.Sleep(60500);
        Console.WriteLine("");
        Console.WriteLine("How did you feel when it was complete?");
        Console.WriteLine("");
        Thread.Sleep(20000);
         Console.WriteLine("");
        Console.WriteLine("Did this experience bless your life or make it worse?");
        Console.WriteLine("");
        Thread.Sleep(20000);
         Console.WriteLine("");
        Console.WriteLine("Well done!!.");
        
    }
     
    static void StartListingActivity()
{
    Console.WriteLine("");
    Console.WriteLine("Welcome to the Listing activity.");
    Console.WriteLine("");
    Thread.Sleep(5000);
    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as");
    Console.WriteLine("many things you can in a certain area.");
    Thread.Sleep(10000);
    Console.WriteLine("");
    Console.WriteLine("Get ready....");
    Thread.Sleep(5000);
    Console.WriteLine("");
    Console.WriteLine("Note: Press Enter after each item. Press Enter twice to finish your list.");
    Console.WriteLine("");
    Thread.Sleep(10000);
    Console.WriteLine("Start listing:");

    // Create a list to store the user's items
    var gratitudeList = new List<string>();

    string item;
    do
    {
        item = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(item))
        {
            gratitudeList.Add(item);
        }

    } while (!string.IsNullOrWhiteSpace(item));

    Console.WriteLine("\nYour gratitude list:");
    for (int i = 0; i < gratitudeList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {gratitudeList[i]}");
    }
    Console.WriteLine("");
    Console.WriteLine("Well done!!");
 }
}