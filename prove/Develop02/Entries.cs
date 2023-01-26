using System;

public class newEntry{

    public string _question;
    private string _Answer;
    public newEntry(string _question){
        this._question = _question;
    }
    public void display(){
         Console.WriteLine(this._question);
         // Reading the user response to the question
        this._Answer = Console.ReadLine();

        // the file to store the question and answer from the user
        string fileName = "entryData.txt";

        // using the date constructor to get the current date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        // Using the streamwriter class module
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(this._question);
            outputFile.WriteLine($"Date: {dateText} {this._Answer}");
        }
    }
}

/*
using System;
public class Resume{

    public string _name;
    public List<Job> _jobs = new List<Job>();
    

public void Display(){
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("Jobs:");

    foreach(Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJob();
        }
}
}
*/ 