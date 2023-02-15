using System;

class Assignment{
    protected string _studentName;
    protected string _topic;
    public Assignment(){
        _studentName = "Unknown";
        _topic = "Unknown";
    }
    public void setStudentName(string studentName){
        _studentName = studentName;
    }
    public void setTopic(string topic){
        _topic = topic;
    }
    public string getStudentName(){
        return _studentName;
    }
    public string getTopic(){
        return _topic;
    }

    public string getSummary(){
        return $"{_studentName} - {_topic}";
    }
}