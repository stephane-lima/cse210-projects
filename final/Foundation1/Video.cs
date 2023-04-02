using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumberOfComment()
    {
        return _comments.Count();
    }
    public void DisplayVideo()
    {
        Console.Write($"{_title} - by {_author}\n");
        Console.Write($"Duration: {_length}\n");
        Console.WriteLine($"Comments: {NumberOfComment()} ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

    }
}