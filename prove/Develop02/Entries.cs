using System;

public class newEntry{

    public string _question;
    private string _Answer;
    public List<Display> _data = new List<Display>();
    public newEntry(string _question, string _Answer){
        this._question = _question;
        this._Answer = _Answer;
    }


    public void display(){
         Console.WriteLine(this._question);
         // Reading the user response to the question
        this._Answer = Console.ReadLine();

        //Storing the datas into an external list
        // string fileName = "enryData.txt";
        // Using the streamwriter class module
        // using (StreamWriter outputFile = new StreamWriter(fileName)){
        //     outputFile.WriteLine(this._question);
        //     outputFile.WriteLine($"Date: {dateText} {this._Answer}");
        // }
    }

    public void storeQandA(){
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        
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