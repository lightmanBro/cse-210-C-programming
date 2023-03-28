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

    public int commentCount(string comment){

        return comment.Count();
    }
}