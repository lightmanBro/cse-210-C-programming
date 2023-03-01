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

    // setting the duration of time the program should run for.
    public void setDuration(string dur){
        _activityDur = int.Parse(dur);
    }

    // the welcoming messages to display
    public void displayMessage(){
        Console.WriteLine($"{_activityName}\n{_activityDesc}");
    }

    public void countdownTimer(){
        Console.WriteLine("How long do you want the program to run for in seconds ?");
        string ans = Console.ReadLine();
        //calling the duration function here and passing the ans variable into it as a parameter;
        setDuration(ans);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(int.Parse(ans)*1000);
        Thread.Sleep(_activityDur*1000);
        Console.WriteLine(_activityDur*1000);
    }

    public void displaySpinner(){
        Console.WriteLine("Get Ready...");
        void spinner(int i){
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write(i+"/5");
        }
        int i = 1;
        while(i<6){
            spinner(i);
            i++;
        }
    }

    // the finishing message to display
    public void finishingMsg(){
        Console.WriteLine("well done!!");
		Console.WriteLine( $"You have completed another {_activityDur} of {_activityName}");
	}
}