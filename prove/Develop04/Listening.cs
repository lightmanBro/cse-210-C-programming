using System;
class Listening:Activity{

    public List<string> _listeningQues = new List<string>();
    private List<string> _listeningAns = new List<string>();
    


    //setting the questions to be displayed to the user
    public void setQuestion(string question){
        _listeningQues.Add($"{question}");
    }

    string random(){
            var random = new Random();
            //saving the random number picked from the length of the list into the string variable index.
            int index = random.Next(_listeningQues.Count);
            string wrds = _listeningQues[index];
            Console.WriteLine(wrds);
            return $"{wrds}";
        }
    private void displayQues(){
        
        //loop through all the questions and display it randomly one after and return it each so as to save it inside a variable.
        //do while loop
        Console.WriteLine("write Quit when done");
        string quit ="";
        do
        { 
            //saving the returned string from the random() into a variable
            string wrds = random();
            Console.WriteLine(wrds);
            Console.WriteLine("Waiting for reflection");
            displaySpinner();
            quit = Console.ReadLine();
        } while (quit.ToLower() != "quit");
    }

    //take the returned question and pass it as a parameter to this function 
    public void saveAns(string ques, string ans){
		_listeningAns.Add($"{ques}\n{ans}");
        }


    public void listen(){
        //welcoming message
        displayMessage();
        //count down timer for the amount of time scheduled for the session
        Console.WriteLine("Get ready...");
        //display the animation ehile the user is getting ready for the activity.
        displaySpinner();
        string ques = random();
            //display the spinner awaiting an answer to the question
            // displaySpinner();

            Console.Write(">");
            string ans = Console.ReadLine();
            //save the answers inside a new list so it could be displayed later
            saveAns(ques,ans);
            Console.WriteLine(_listeningAns[0]);
            // perform all the activities here
            Console.WriteLine("We have not arrived at our future time yet...");
            
        // }if(currentTime == futureTime){
        //     // use if stetement to ask the user to save the answers to an external text file or display it inside the console immediately
        //     Console.WriteLine("Do you want to view your entries? ");
        //     string ans = Console.ReadLine();
        //     if(ans.ToLower() == "yes"){
        //         displayEntries();
        //         finishingMsg();
        //     }else{
        //         finishingMsg();
        //     }
        //     //display the finishing message.
        //     // finishingMsg();
        // }
    }
    public void displayEntries(){
        foreach(string ans in _listeningAns){
            Console.WriteLine(ans);
        }
    }
}