using System;
class Breathing:Activity{

    public void breathe(){
        displayMessage();
        countdownTimer();
        displaySpinner();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);
        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {

            // perform all the activities here
            Console.WriteLine("We have not arrived at our future time yet...");
        }else if(currentTime == futureTime){


        }
    }
}