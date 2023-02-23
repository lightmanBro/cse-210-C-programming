using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine("Going to sleep for a second...");

        int i = 0;
        while(i<1){
            Console.Write("+");
            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            i++;
        }


        //Pausing time
        // Thread.Sleep(5000);

        // Console.WriteLine("I'm back!!");
        // Console.WriteLine("what is your grade percentage? ");
        Console.WriteLine("how long do you want the program to run for?");
        string ans = Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);

        Thread.Sleep(int.Parse(ans)*100);
        Console.WriteLine(int.Parse(ans)*1000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
    }
} 