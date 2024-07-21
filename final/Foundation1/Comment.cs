public class Comment 
{
    public string _commenter;
    public string _content;

    public Comment(string commenter, string content)
    {
        _commenter = commenter;
        _content = content;
    }

    public void Display()
    {
        Console.WriteLine($"{_commenter}: {_content}");
    }
}