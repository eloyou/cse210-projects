using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public double _length;

    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    public void Display()
    {
        Console.WriteLine($"\nVideo: {_title} {_length} min by {_author}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (Comment c in _comments)
        {
            
            Console.WriteLine($"Comment: {c._comment} - ({c._commentor})");
        
            
        }
    }


    
}