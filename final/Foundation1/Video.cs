public class Video
{
    public string _author;
    public string _title;
    public int _length;

    public List<Comment> _commentList = new List<Comment>();


    public Video (string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public void Display()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("");
        Console.WriteLine($"{_title}");
        Console.WriteLine($"By: {_author}, {_length} seconds long");
        Console.WriteLine("");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _commentList)
        {
            comment.Display();
        }
        Console.WriteLine("");

    }
}