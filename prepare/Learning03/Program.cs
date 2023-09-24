using System;
using System.Collections.Generic;

namespace SimpleJournal
{
    class JournalEntry
    {
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }

    class Program
    {
        static List<JournalEntry> journalEntries = new List<JournalEntry>();

        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Welcome to the journal program");
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What will you like to do? ");

                string choice = Console.ReadLine();

                 switch (choice)
                {
                    case "1":
                        AddJournalEntry();
                        break;

                    case "2":
                        ViewJournalEntries();
                        break;

                    case "3":
                        continueRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddJournalEntry()
        {
            Console.WriteLine("Enter the date (e.g., YYYY-MM-DD):");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Enter your journal entry:");
                string content = Console.ReadLine();

                JournalEntry entry = new JournalEntry
                {
                    Date = date,
                    Content = content
                };

                journalEntries.Add(entry);
                Console.WriteLine("Journal entry added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.");
            }
        }

        static void ViewJournalEntries()
        {
            Console.WriteLine("Journal Entries:");
            foreach (var entry in journalEntries)
            {
                Console.WriteLine($"Date: {entry.Date.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Entry: {entry.Content}");
                Console.WriteLine();
            }
        }
    }
}
