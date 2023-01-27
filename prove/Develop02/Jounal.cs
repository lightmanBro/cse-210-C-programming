using System;
using System.IO;
using System.Collections.Generic;
public class journal
{
    public string _fname = "";
    public List<newEntry> _entry = new List<newEntry>();
    List<string> datas = new List<string>();
    /*
    storing the display classes
    contents in a list so that it can be looped over and the contents
    inside it can be used.
    */ 
    

    public void showJournalDatas()
    {

    }
    public void DisplayEntries()
{        void question(){
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
        }
            //getting inputs from the readline method
            
        Console.WriteLine("Please select one of the following");
        question();
        
        _fname = Console.ReadLine();
        while(int.Parse(_fname) != 5){
            question();
            Console.WriteLine("What would you like to do?");
    
            if (int.Parse(_fname) == 1){
                foreach (newEntry ent in _entry)
                {
                    // calling the entry display method to display the question
                    ent.display();
                    ent.storeQandA();
                }
                /*loop through the entries with math.rand method and display the entries,
                After displaying the enteries get the answer to the
                entries and save it to a new list with the questions and date */
            }


            else if (int.Parse(_fname) == 2)
            {
                
            }
            else if (int.Parse(_fname) == 3)
            {
                

            }
            else if (int.Parse(_fname) == 4)
            {
                Console.WriteLine("Enter the name of the file.");
                string fileDirectoryName = Console.ReadLine();

            }
            else if (_fname.ToLower() == "quit" || int.Parse(_fname) == 5)
            {

            }
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