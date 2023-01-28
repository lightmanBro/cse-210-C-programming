using System;

class Program
{
    static void Main(string[] args)
    {



        
        // Console.WriteLine("what is your name");
        //  string Answer = Console.ReadLine();
        // Console.Write(Answer);
        newEntry question1 = new newEntry("If I had one thing I could do over today, what would it be?");
        newEntry question2 = new newEntry("What was the best part of my day?");
        newEntry question3 = new newEntry("Who was the best person you spoke to today");
        // These will be in a while loop
        
        // initializing the journal class so as to use it here
        journal newJornal = new journal();
        newJornal._entry.Add(question1);
        newJornal._entry.Add(question2);
        newJornal._entry.Add(question3);

        // Initializing the questions to be asked
         void question(){
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
        }

        // calling the question displey function.
        question();
        var ans = Console.ReadLine();
        newJornal.displayQuestion();
        newJornal.showEnteries();
        newJornal.saveEntriesToExt();
        newJornal.loadEntriesFromExt();
         

    

       

       
    }
}