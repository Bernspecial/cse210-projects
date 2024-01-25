using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word;

    public Scripture(Reference Reference, string text)
    {
        _word = new List<Word>();

        _reference = Reference;

         string[] split = text.Split(' ');     
         foreach(string splitted in split)
         {
            _word.Add(new Word(splitted));
         }
         
    }

    public void HideRandonWord(int numberToHide)
    {
        Random random = new Random();
        while (numberToHide > 0)
        {
            int nextNum = random.Next(_word.Count);

            if (!_word[nextNum].IsHidden())
            {
                _word[nextNum].Hide();
                numberToHide --;
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()} - ";
        foreach (Word word in _word)
        {
            displayText += word.GetDisplayText() + " ";
            
        }
        return displayText;
    }
    
    public bool IsCompletelyHiden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}