using System;
using System.Collections.Generic;
using System.IO;



class Program
{
    static void Main()
    {
        QuestSystem questSystem = new QuestSystem();

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Display User Score");
            Console.WriteLine("  7. Exit");
            Console.WriteLine("Select a choice from the menu:");
           

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple");
                    Console.WriteLine("2. Eternal");
                    Console.WriteLine("3. Checklist");
                    int goalTypeChoice = int.Parse(Console.ReadLine());
                    Console.Write("Write a short discription of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("What is the amount of point associated with this goal? ");
                    int value = int.Parse(Console.ReadLine());
                    if (goalTypeChoice == 3)
                    {
                        Console.Write("Enter target count for the checklist goal: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        questSystem.CreateGoal(name, value, (GoalType)(goalTypeChoice - 1), targetCount);
                    }
                    else
                    {
                        questSystem.CreateGoal(name, value, (GoalType)(goalTypeChoice - 1));
                    }
                    break;
               
                case 2:
                    questSystem.DisplayGoals();
                    break;
                
             
                case 3:
                    Console.Write("Enter the file path to save goals: ");
                    string savePath = Console.ReadLine();
                    questSystem.SaveGoals(savePath);
                    break;
                case 4:
                    Console.Write("Enter the file path to load goals: ");
                    string loadPath = Console.ReadLine();
                    questSystem.LoadGoals(loadPath);
                    break;
                case 5:
                    questSystem.DisplayGoals();
                    Console.Write("Enter the goal number to record an event: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    questSystem.RecordEvent(goalIndex);
                    break;
                
                case 6:
                    questSystem.DisplayUserScore();
                    break;
                case 7:
                    return;
            }
        }
    }
}