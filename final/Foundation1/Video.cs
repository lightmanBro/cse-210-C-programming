public class Video
{

    public string _title;
    public string _author;
    public double _length;

    List<string> comments = new List<string>();
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComentsToList(string c)
    {
        comments.Add(c);
    }
    public void displayVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Duration: {_length}mins");
        Console.WriteLine($"Posted by: {_author}\n___________________ ");
        Console.WriteLine($" {comments.Count()} comments");
        Console.WriteLine();
        foreach (var com in comments)
        {
            Console.WriteLine(com);
            Console.WriteLine();
        }
    }
}