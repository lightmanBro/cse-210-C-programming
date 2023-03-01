using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine("Going to sleep for a second...");
        // void spinner(int i){
        //     Console.Write("+");
        //     Thread.Sleep(500);
        //     Console.Write("\b \b"); // Erase the + character
        //     Console.Clear();
        //     Console.Write(i+"/10");
        //     Console.Write("-"); // Replace it with the - character
        //     Thread.Sleep(500);
        //     Console.Write("\b \b"); // Erase the + character
        // }
        // int i = 1;
        // while(i<10){
        //     spinner(i);

        //     i++;
        // }


        //Pausing time
        // Thread.Sleep(5000);

        // Console.WriteLine("I'm back!!");
        // Console.WriteLine("what is your grade percentage? ");
        // Console.WriteLine("how long do you want the program to run for?");
        // string ans = Console.ReadLine();
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(5000);

        // Thread.Sleep(int.Parse(ans)*100);
        // Console.WriteLine(int.Parse(ans)*1000);

        // DateTime currentTime = DateTime.Now;
        // if (currentTime < futureTime)
        // {
        //     Console.WriteLine("We have not arrived at our future time yet...");
        // }
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);

        // Thread.Sleep(10000);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Arrives");
        
        }
        
    }
} 