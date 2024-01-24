using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Scripture
{
    private string _fullText;
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _fullText = text;
         string[] words = text.Split(' ');
        

        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }

    public void HideRandomWords(int number=1)
    {
        Random random = new Random();

        for (int i = 0; i < number; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = random.Next(_words.Count);
                
            }
            while (_words[randomIndex].IsHidden());
            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()

    {

         StringBuilder text = new StringBuilder();

         text.Append(_reference.GetDisplayText());

        // Loop through the array of words using foreach
        foreach (Word word in _words)
        {
            
            text.Append(word.GetDisplayText());
            text.Append(" ");
        }

        return text.ToString();
    }

    public bool IsCompletelyHidden()

    {   bool quit;

        if (_words.All(data => data.IsHidden()))
        {
            quit = true;
        }
        else
        {
            quit = false;
        }

        return quit;

        
    }

    public void ShowFullText()
    {
        Console.WriteLine($"{_reference.GetDisplayText()} {_fullText}");
    }



    

    

}