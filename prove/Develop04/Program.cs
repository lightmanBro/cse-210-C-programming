using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        // Console.WriteLine("Menu Options:");
        // Console.WriteLine("    1. Start Breathing activity");
        // Console.WriteLine("    2. Start Reflecting activity");
        // Console.WriteLine("    3. Start listening activity");
        // Console.WriteLine("    4. Start Breathing activity");
        // Console.WriteLine("    5.Quit");
        // Console.Write("Select from a random choice");
        // string ans = Console.ReadLine();

        // if (int.Parse(ans) ==1)
        // {
            
        // }
        // Activity activity = new Activity();
        // activity.setActivity("mindfulness","Reading minds");
        // string breathingMessage = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
        // Listening listen = new Listening();
        // listen.setActivity("Welcome to Breathing Activity",breathingMessage);
        // listen.setQuestion("How have you been doing for the most part of this week");
        // listen.setQuestion("What are you happy about mostly this past month");
        // listen.setQuestion("who inspires you the most in your life");
        // listen.listen();

        Breathing breath = new Breathing();
        breath.breathe();
        
    }
}