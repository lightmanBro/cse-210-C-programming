using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("NUMBER GUESSING GAME");


        Random randomNum = new Random();
        int magicNumber = randomNum.Next(1, 20);

        int answer = 0;
        int guessTimes = 1;

        while(answer != 5 && guessTimes <4) {
            Console.Write("What is youŕ guess?");
           string guess = Console.ReadLine();

            if( int.Parse(guess)== answer ){
                Console.WriteLine("You guessed it");
            }
            if(int.Parse(guess)>answer){
                Console.WriteLine("Higher", "you have "+ (guessTimes+1) + " guesses left");
            }
            if(int.Parse(guess)<answer){
                Console.Write("Lower");
                Console.WriteLine("Higher", "you have "+ (guessTimes+1) + " guesses left");
            }
            guessTimes+=1;
        }
        // for (int i = 0; i < 20; i = i + 2)
        // {
        //     Console.WriteLine(i++);
        // }

        // string colors = "BrownBelt";

        // foreach( c in color)
        // {

        // }

        // foreach (string color in color)
        // {
        //     Console.WriteLine(color);
        // }
    }
}