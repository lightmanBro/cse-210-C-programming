using System;
class Breathing:Activity{

    public void breathe()
    {
        Console.WriteLine("Get ready...");
        Thread.Sleep(5000);
        breathIn();
        breathOut();
        finishingMsg();
    }

    public void breathIn(){
        int i = 1;
        Console.Write("Breathe...",i);
        while(i<=4){
            
            // Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            // Console.Write("-"); // Replace it with the - character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            // Console.Write("|"); // Erase the + character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            Console.Write(i);
            i+=1;
            if(i ==-1){
                return;
            }
        }
    }

    public void breathOut(){
        int i = 4;
        Console.Write("Now breathe out...");
        while(i<=4){
            // Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            // Console.Write("-"); // Replace it with the - character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            // Console.Write("|"); // Erase the + character
            // Thread.Sleep(500);
            // Console.Write("\b \b"); // Erase the + character
            Console.Write(i);
            i-=1;
            if(i ==-1){
                return;
            }
        }
        Thread.Sleep
    }
 public void breathing(){
    displayMessage();
    displaySpinner();

    Console.WriteLine("How long would you like this activity to run for?");
    string Dur = Console.ReadLine();
    string timeToRun = setDuration(Dur);
    int start = 0;
    while(start<int.Parse(timeToRun)){

    }
 }

}