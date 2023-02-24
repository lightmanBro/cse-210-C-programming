using System;
class Activity{
    private string _activityName;
    private string _activityDesc;
    private int _activityDur;

    public Activity(){
        //default constructor parameters.
		_activityName = "Unknown";
		_activityDesc = "Unknown";
        _activityDur = 0;
	}
    
    // setting the member variables
    public string setActivity(string name,string desc){
        _activityName = name;
        _activityDesc = desc;
        return $"{name}\n {desc}";
    }

    public void setDuration(string dur){
        _activityDur = int.Parse(dur);
    }

    // the welcoming messages to display
    public string displayMessage(){
        return $"{_activityName}\n{_activityDesc}";
    }

    public void countdownTimer(){
        Console.WriteLine("how long do you want the program to run for?");
        string ans = Console.ReadLine();
        //setting the duration of time the program should run for
        setDuration(ans);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);
        Thread.Sleep(_activityDur*100);
        Console.WriteLine(_activityDur*1000);
    }

    public void displaySpinner(){
        int i = 0;
        while(i<1){
            Console.Write("+");
            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            i++;
        }
    }
    // the finishing message to display
    public void finishingMsg(){
        Console.WriteLine("well done!!");
		Console.WriteLine( $"You have completed another {_activityDur} of {_activityName}");
	}
}