using System;
class Listening:Activity{

    private List<string> _listeningQues;
    private List<string> _listeningAns;
    
    private void displayQues(){
        //loop through all the questions and display it randomly one after the other to the console.
    }

    public void listen(){
        //welcoming message
        displayMessage();
        //display the questions inside the list
        displayQues();
        //start the countdown timer
        countdownTimer();
        //display the spinner
        displaySpinner();


        // time class function
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);
        DateTime currentTime = DateTime.Now;

        //condition to run the program with time
        if (currentTime < futureTime)
        {

            // perform all the activities here
            Console.WriteLine("We have not arrived at our future time yet...");
        }else if(currentTime == futureTime){

            finishingMsg();
        }
    }
}