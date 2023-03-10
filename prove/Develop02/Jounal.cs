using System;
using System.IO;
using System.Collections.Generic;
public class journal
{
    public List<newEntry> _entry = new List<newEntry>();

    // created a new list to store all the user enteries
    List<string> _userDetails = new List<string>();

    List<string> questions = new List<string>();

    // initializing the list where to save the list of the Entry title
    List<string> _entryTitle = new List<string>();


    // initializing the method to save the questions
    public void saveQuestions()
    {
    
        foreach (newEntry entry in _entry)
        {
            // Adding the questions to a specific list so as to use the random method on it safely
            questions.Add(entry._question);
            // To add multiple data into a list at once in C#
            // string[] UserEnteries = {
            //     entry._question,
            //     entry._date,
            //     entry._Answer
            // };
            // _userDetails.AddRange(UserEnteries);
            _userDetails.Add($"'{entry._question}', '{entry._date}','{entry._Answer}'");
        }
    }

    public void displayQuestion()
    {
       Console.WriteLine(questions);
        foreach (newEntry entry in _entry)
        {
            entry.displayQ(entry._question);
            entry._Answer = Console.ReadLine();
            this.saveQuestions();
        }
    }

    public void showEnteries()
    {
        if(_userDetails.Count > 0){

        foreach (var _item in _userDetails)
        {
            Console.WriteLine(_item);
        }
        }else if(_userDetails.Count < 1){
            Console.WriteLine("Your Entry is Empty");
            Console.WriteLine("Do you want to read from your saved files? Enter Yes/No");
            string _ans = Console.ReadLine();
            if(_ans.ToLower() == "yes"){
                this.loadEntriesFromExt();
            }else{
                return;
            }
            
        }
    }


    public void saveEntriesToExt()
    {
        Console.WriteLine("Enter file name");
        string _fileName = Console.ReadLine();
        // to add a file as a json file then the AddRange() should be used.
        _entryTitle.Add(_fileName);

        using (StreamWriter outputFile = new StreamWriter($"{_fileName}.txt"))
        {
            foreach (var _item in _userDetails)
            {
                outputFile.WriteLine($"[{_item}],");
            

            }
            // You can add text to the file with the WriteLine method
        }

    }

    // Method to load data from external files.
    public void loadEntriesFromExt()
    {

        Console.WriteLine("These is/are the files you have");
        // looping through the list where the entry titles are stored
        foreach (var _title in _entryTitle)
        {
            Console.WriteLine(_title);
        }

        Console.WriteLine("Please Enter file name to see the contents");
        string filename = Console.ReadLine();
        // method to read from the external file contents
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");
        // looping theough the contents of the file and printig it to the console.
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}