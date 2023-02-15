using System;
class Mathematics:Assignment{

    private string _textbookSession,_problem;
    
    public Mathematics(){
        _textbookSession = "Unknown";
        _problem = "Unknown";
    }
    public string getTextBookSession(){
        return _textbookSession;
    }

    public string getProblem(){
        return _problem;
    }
    public void setTextBookSession(string session){
        _textbookSession = session;
    }
    public void setProblem(string problem){
        _problem = problem;
    }

    public string getHomeworkList(){
        return $"{_studentName} {_topic} {_textbookSession} {_problem}";
    }
}