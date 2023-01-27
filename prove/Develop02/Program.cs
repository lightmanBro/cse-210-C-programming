using System;

class Program
{
    static void Main(string[] args)
    {



        
        // Console.WriteLine("what is your name");
        //  string Answer = Console.ReadLine();
        // Console.Write(Answer);
        newEntry question1 = new newEntry("What makes you feel so proud of yourself today?");
        newEntry question2 = new newEntry("Why did you get up so late today?");
        // These will be in a while loop
        
        // initializing the journal class so as to use it here
        journal newJornal = new journal();
        newJornal._entry.Add(question1);
        newJornal._entry.Add(question2);

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
        Console.Write(">");


        // looping and checking the answer if it meets the condition.



        // displaying the question
        newJornal.displayQuestion(); 

    }
}