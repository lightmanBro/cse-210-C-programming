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
        Activity activity = new Activity();
        activity.setActivity("mindfulness","Reading minds");
        Console.WriteLine(activity.displayMessage());
    }
}