public class Video{

    public string _title;
    public string _author;
    public double _length;

    List<string> comments = new List<string>();
    public Video(string title,string author, double length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComentsToList(string c){
        comments.Add(c);
    }
    public int commentCount(string comment){
        return comments.Count();
    }

    public void displayVideo(){
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_length);

        foreach (var com in comments)
        {
            Console.WriteLine(com);
        }
    }
}