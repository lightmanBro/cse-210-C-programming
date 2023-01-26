using System;
using System. IO;
public class journal{
    public List<newEntry> _entry = new List<newEntry>();
    
    public string fname;
    public void DisplayEntries(){

        // getting inputs from the readline method
        if(fname == "write" || int.Parse(fname) == 1){
             foreach(newEntry ent in _entry){
            // calling the entry display method to display the question 
                ent.display();
        }
            /*loop through the entries with math.rand method and display the entries,
            After displaying the enteries get the answer to the
            entries and save it to a new list with the questions and date */
        }else if(fname == "Display" || int.Parse(fname) == 2){

        }else if(fname == "Load" || int.Parse(fname) == 3){

        }else if(fname == "Save" || int.Parse(fname) == 4){

        }else if(fname == "Quit" || int.Parse(fname) == 5){

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