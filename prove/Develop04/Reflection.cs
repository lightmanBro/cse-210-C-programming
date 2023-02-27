using System;
class Reflection:Activity{
    private List<string> _reflectQues;

    public void addQues(string ques){
        _reflectQues.Add(ques);
    }

    private void displaRefQues(){
        // randomly display the questions inside the list
        var random = new Random();
        //saving the random number picked from the length of the list into the string variable index.
        int index = random.Next(_reflectQues.Count);
        string wrds = _reflectQues[index];
        Console.WriteLine(wrds); //question
    }

    public void reflect(){
        displayMessage();
        displaRefQues();
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

            finishingMsg();
        }
    }
}