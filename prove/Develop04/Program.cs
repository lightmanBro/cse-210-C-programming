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


        Reflection reflect = new Reflection();
         reflect.setActivity("Breathing Activity","This activity will help you to calm down and master the art of reflecting");
        //Questions 
        string qone,qtwo,qthree,qfour;
        qone = ("Think of a time when you stood up for someone else");
        qtwo = ("Think of a time when you did something really difficult.");
        qthree = ("Think of a time when you helped someone in need.");
        qfour = ("Think of a time when you did something truly selfless.");
        reflect.addQues(qone);
        reflect.addQues(qtwo);
        reflect.addQues(qthree);
        reflect.addQues(qfour);


        //sub Questions lists
        string one,two,three,four,five,six,seven,eight,nine;
        one = "Why was this experience meaningful to you?";
        two = "Have you ever done anything like this before?";
        three = "How did you get started?";
        four = "How did you feel when it was complete?";
        five = "What made this time different than other times when you were not as successful?";
        six = "What is your favorite thing about this experience?";
        seven = "What is your favorite thing about this experience?";
        eight = "What did you learn about yourself through this experience?";
        nine = "How can you keep this experience in mind in the future?";
        reflect.addListsPrompt(one);
        reflect.addListsPrompt(two);
        reflect.addListsPrompt(three);
        reflect.addListsPrompt(four);
        reflect.addListsPrompt(five);
        reflect.addListsPrompt(six);
        reflect.addListsPrompt(seven);
        reflect.addListsPrompt(eight);
        reflect.addListsPrompt(nine);



        //calling the fuctions
        // reflect.reflect();

        string BrName = "Breathing Activity";
        string BrDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Breathing breathe = new Breathing();
        breathe.setActivity(BrName,BrDesc);
        


    }
}