using System;
using System.IO;
using System.Collections.Generic;
public class journal
{
    public List<newEntry> _entry = new List<newEntry>();

    // created a new list to store all the user enteries
    List<string> _userDetails = new List<string>();

    // initializing the list where to save the list of the Entry title
    List<string> _entryTitle = new List<string>();


    // initializing the method to save the questions
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

    public void displayQuestion()
    {
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

        foreach (var item in _userDetails)
        {
            Console.WriteLine(item);
        }
        }else if(_userDetails.Count < 1){
            Console.WriteLine("Your Entry is Empty");
            Console.WriteLine("Do you want to read from your saved files?");
            string ans = Console.ReadLine();
            if(ans == "yes"){
                this.loadEntriesFromExt();
            }else{
                this.displayQuestion();
            }
            
        }
    }


    public void saveEntriesToExt()
    {
        Console.WriteLine("Enter file name");
        string fileName = Console.ReadLine();
        _entryTitle.Add(fileName);

        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
        {
            foreach (var item in _userDetails)
            {
                outputFile.WriteLine(item);

            }
            // You can add text to the file with the WriteLine method
        }

    }

    public void loadEntriesFromExt()
    {

        Console.WriteLine("These is/are the files you have");
        foreach (var title in _entryTitle)
        {
            Console.WriteLine(title);
        }

        Console.WriteLine("Please Enter file name to see the contents");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        // looping theough the contents of the file and printig it to the console.
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}