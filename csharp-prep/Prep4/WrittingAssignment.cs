using System;

class WritingAss:Assignment{

     private string _title,_textbookSession;

     public WritingAss(){
        _title = "Unknown";
     }

     public string getTitle(){
        return _title;
    }
    public void setTitle(string title){
        _title = title;
    }
    public void setTextBookSession(string session){
        _textbookSession = session;
    }
    public string getWrittingInfo(){
        return $"{_studentName} - {_title} :{_textbookSession}";
    }
    
}