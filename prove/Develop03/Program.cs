class Program
{
    static void Main()
    {
        
        var reference = new Reference("D&C", 6, 28);
        var wordsToHide = new List<string>
        {
            "And now, behold, I give unto you,", "and unto my servant Joseph,", "the keys of this gift,", "which shall bring to light this ministry;", "and in the mouth of two or three witnesses", "shall every word be established."
        };
        var scripture = new Scripture(reference, wordsToHide);

        bool quit = false;

        while (!scripture.AllWordsHidden() && !quit)
        {
            Console.Clear(); 
            scripture.Display();
            Console.WriteLine("Press Enter to continue, or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideNextWord();
            }
        }

        Console.Clear(); 
        scripture.Display();
        Console.WriteLine("All the words are hidden. You've successfully memorized the scripture! :)");
    }
}