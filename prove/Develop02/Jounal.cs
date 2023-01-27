using System;
using System.IO;using System.Collections.Generic;
public class journal
{
    public List<newEntry> _entry = new List<newEntry>();


    // created a new list to store all the user enteries
    List<string> _userDetails = new List<string>();

    public List<Display> _data = new List<Display>();

    public void saveQuestions()
    {
        foreach (newEntry entry in _entry)
        {

            // To add multiple data into a list at once in C#
            string[] UserEnteries = {
                entry._question,
                entry._date,
                entry._Answer
            };
            _userDetails.AddRange(UserEnteries);
        }
    }
    public void displayQuestion(){
        foreach (newEntry entry in _entry)
        {
            entry.displayQ();
            entry._Answer =  Console.ReadLine();
            this.saveQuestions();

        }
    }

        
        
        


    
}