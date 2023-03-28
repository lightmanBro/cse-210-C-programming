public class Comments{

    public string _commenterName;
    public string _comments;

    public string addComments(string name,string com){
       
        return $"{name} comment: {com}";
    }
}