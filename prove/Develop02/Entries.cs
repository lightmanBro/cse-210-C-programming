using System;

public class newEntry{

    public string _question;
    public string _Answer;
    public string _date;
    
    // Creating a constructor for the new Entry function
    public newEntry(string _question){
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        this._question = _question;
        this._date = dateText;
    }
    public void displayQ(string question){
        Console.WriteLine(this._question);

    }

    // public void displayEnteries(){
    //     Console.WriteLine(this._question);
    //     Console.Write($"{this._date}: {this._Answer}");
    // }
}


