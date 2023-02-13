using System;
//This class will keep track of the reference and text of the scripture. It will hide words and get the rendered text.

public class Scripture
{
    private List<Word> _wordsList = new List<Word>();
    private List<int> _indexList = new List<int>();
    private Reference _reference;
    private bool _everythingIsHidden;
    private int _wordHiddenCount = 0;
    private string _scriptureText;
    private int _randomIndex;
    private int _index;

    public Scripture(string scripture, Reference reference)
    {
        _scriptureText = scripture;
        _reference = reference;
    }
    
    //Transform scripture in words list.
    public void WordList()
    {
        foreach (string word in _scriptureText.Split(" "))
        {
            Word words = new Word(word);
            _wordsList.Add(words);
        }
    }
    
    //Populate indexes to not repeat the indexes while hiding words.
    public List<int> Populate()
    {
        for (int i = 0; i < _scriptureText.Split(" ").Count(); i++)
        {
            _indexList.Add(i);
        }
        return _indexList;
    }
    
    //Hide each word and does not repeat 
    public void HideWords()
    {
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            if (_indexList.Count == 0)
            {
                Populate();
            }
            
            _randomIndex = random.Next(_indexList.Count);
            _index = _indexList[_randomIndex];
            _indexList.RemoveAt(_randomIndex);
            _wordsList[_index].Hidden();
            
            if (_wordsList[_index].GetHidden() == true)
            {
                _wordHiddenCount++;
            }
        }
    }
    
    //Display scripture.
    public void Display()
    {
        Console.Write($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetInitialVerse()}-{_reference.GetEndVerse()} - ");
        
        foreach (Word element in _wordsList)
        {
            Console.Write($"{element.GetWord()} ");
        }
    }

    //If all words are hidden, the value is false. It will be used to finish the program when all words are hidden.
    public bool EverythingIsHidden()
    {
        _everythingIsHidden = _wordsList.Any(word => word.GetHidden() == false);
        return _everythingIsHidden;
    }
}



