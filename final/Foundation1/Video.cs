using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
private string _title;
private string _author;
private int _length;

List<Comment> _comments = new List<Comment>();

public Video(string title, string author, int length)
{
    _title = title;
    _author = author;
    _length = length;
}
public void DisplayInfo()
{
    Console.WriteLine($"{_title} by {_author} -- {_length} seconds ");
}
public int GetNumberOfComments()
{
    return _comments.Count; 
}
public void AddComment(Comment comment)
{
    _comments.Add(comment);
}
public void DisplayComments()
{
    foreach(Comment comment in _comments)
    {
        Console.Write(comment.GetName());
        Console.Write(" - ");
        Console.WriteLine(comment.GetText());
    }
}

}