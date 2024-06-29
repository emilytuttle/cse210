using System.Text.Encodings.Web;

public class Word
{
    public string _text;
    public bool _isHidden;
    public int _numberOfLetters;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        string underscore = "";
        int numberOfLetters = _text.Length;
        if (!_isHidden)
        {
            return _text;
        }
        else 
        {
            for (int i=0; i < numberOfLetters; i++)
            {
                underscore = underscore + "_";
            }
            return underscore;
        }
        
    }
}