using System;

public class Reference {

    private string _book = "Proverbs";
    private string _chapter = "3";
    private string _startVerse = "5";
    private string _endVerse = "6";
    private string _verseContent = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy was acknowledge him, and he shall direct thy paths.";
    private string _reference;

    public string GenerateReference() 
    {
        _reference = _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse + " ";
        return _reference;
    }

    public string GetVerseContent() 
    {
        return _verseContent;
    }

    // public void SetVerseContent(string verseContent) 
    // {
    //     _verseContent = verseContent;
    // }

}