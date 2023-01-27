using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.WriteLine("what is your name");
        //  string Answer = Console.ReadLine();
        // Console.Write(Answer);
        newEntry question1 = new newEntry("What are you so happy about today");

        // These will be in a while loop
        
        // initializing the journal class so as to use it here
        journal newJornal = new journal();
        // newJornal._fname = fname;
        newJornal._entry.Add(question1);
        newJornal.DisplayEntries();


        // Writing the name of the class to the constructor function
        Display EntryDisplay = new Display("Display");


        newJornal._data.Add(EntryDisplay);
        EntryDisplay.ShowStoredData();
        // question1.display();
    }
}