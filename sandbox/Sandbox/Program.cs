using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");

        // void spinner(int i){
        //     Console.Write("^_~");
        //     Thread.Sleep(250);
        //     Console.Clear();
        //     Console.Write("^_^");
        //     Thread.Sleep(250);
        //     Console.Clear();
        //     Console.Write("O_O");
        //     Thread.Sleep(250);
        //     Console.Clear();

        // }

        // int i = 1;
        // while(i<10){

        //     spinner(i);

        //     i++;
        // }
        // Console.WriteLine("Going to sleep for a second...");

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
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(5000);

        // // Thread.Sleep(10000);

        // DateTime currentTime = DateTime.Now;
        // while (currentTime < futureTime)
        // {
        //     Console.Write("Arrives");

        // }
        // int time = 1;
        // int stop = 10;
        // string ans = "";
        // while(time < stop){
        //     //time for the program to pause
        //     Thread.Sleep(1000);

        //     Console.WriteLine("Not there");
        //     ans = Console.ReadLine();
        //     time+=1;
        // }if(time == stop){
        //     Console.Write("Now there");
        // }

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(15);
        DateTime currentTime = DateTime.Now;
        TimeSpan delay = futureTime - currentTime;
        Timer time = new Timer(TimerCallback,null,delay,Timeout.InfiniteTimeSpan);
        Console.WriteLine(futureTime);
        Console.ReadKey();
        static void TimerCallback(object state){
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("we there");
        }
    }
}