using System;
class Listening:Activity{

    private List<string> _listeningQues;
    private List<string> _listeningAns;
    
    private string displayQues(){
        //loop through all the questions and display it randomly one after and return it each so as to save it inside a variable.

        return //question
    }


    //take the returned question and pass it as a parameter to this function
    public void saveAns(string ques, string ans){
		_listeningAns.Add($"{ques}\n{ans}");
        }
    public void listen(){
        //welcoming message
        displayMessage();
        //start the countdown timer
        countdownTimer();
        // time class function
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);
        DateTime currentTime = DateTime.Now;

        //condition to run the program with time
        if (currentTime < futureTime)
        {
            //display the questions inside the list
            string ques = displayQues();
            
            //display the spinner awaiting an answer to the question
            displaySpinner();

            Console.Write(">");
            string ans = Console.ReadLine();
            //save the answers inside a new list so it could be displayed later
            saveAns(ques,ans);

            // perform all the activities here
            Console.WriteLine("We have not arrived at our future time yet...");
        }else if(currentTime == futureTime){

            finishingMsg();
        }
    }
}