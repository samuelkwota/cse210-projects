class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }
    private List<int> hiddenWordIndices;
    private int currentHiddenIndex;

    public Scripture(Reference reference, List<string> wordsToHide)
    {
        Reference = reference;
        Words = wordsToHide.Select(word => new Word(word)).ToList();
        hiddenWordIndices = Enumerable.Range(0, Words.Count).ToList();
        Shuffle(hiddenWordIndices);
        currentHiddenIndex = 0;
    }

    public void HideNextWord()
    {
        if (currentHiddenIndex < hiddenWordIndices.Count)
        {
            int indexToHide = hiddenWordIndices[currentHiddenIndex];
            Words[indexToHide].Text = "_________________________________________"; 
            currentHiddenIndex++;
        }
    }

    public bool AllWordsHidden()
    {
        return currentHiddenIndex >= hiddenWordIndices.Count;
    }

    public void Display()
    {
        Console.WriteLine("Try and Memorize these words:");
        Console.WriteLine($"Scripture Reference: {Reference}");
        
        foreach (var word in Words)
        {
            Console.WriteLine(word.Text);
        }
    }

    
    private void Shuffle(List<int> list)
    {
        Random rand = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            int value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
