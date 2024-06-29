public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        
        for (int i = 0; i < words.Length; i++)
        {
            Word word = new Word(words[i]);
            _words.Add(word);
            
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> available = new List<Word>();
        
        foreach (Word word in _words)
        {
            if (!word._isHidden)
            {
                available.Add(word);
            }
        }

        int availableCount = _words.Count();
        List<int> intChoices = new List<int>();
        int choicesLength = intChoices.Count();
        List<int> usedIndexes = new List<int>();
        if (availableCount >= numberToHide)
        {
            while (choicesLength < numberToHide)
            {
                var random = new Random();
                int index = random.Next(0, availableCount);
                if (!intChoices.Contains(index) && !usedIndexes.Contains(index))
                {
                    intChoices.Add(index);
                    choicesLength += 1;
                    usedIndexes.Add(index);
                }
            }
            
            _words[intChoices[0]]._isHidden = true;
            _words[intChoices[1]]._isHidden = true;
        }
        // else
        // {
        //     foreach (Word word in _words)
        //     {
        //         word._isHidden = true;
        //     }
        // }
    }

    

    public void GetDisplayText()
    {
        Console.Clear();
        string referenceToUse = _reference.GetDisplayText();
        Console.Write(referenceToUse);
        foreach (Word word in _words)
        {
            // Console.Write(word._text);
            Console.Write(word.GetDisplayText());
            Console.Write(" ");
        }
        Console.WriteLine();

    }

    public bool IsCompletelyHidden()
    {
        int listLength = _words.Count();
        int notHiddenCount = 0;

        foreach (Word word in _words)
        {
            if (!word._isHidden)
            {
                notHiddenCount -= 1;
            }
            
        
            
        }

        if (notHiddenCount != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }
}