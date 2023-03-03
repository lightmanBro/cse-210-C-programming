using System;
class Reflection:Activity{
    private List<string> _reflectQues = new List<string>();
    private List<string> _reflectLists = new List<string>();

    public void addQues(string rQues){
         _reflectQues.Add(rQues);
    }

    public void addListsPrompt(string ques){
        _reflectLists.Add(ques);
    }
    public void displaRefQues(){
        // randomly display the questions inside the list
        var random = new Random();
        //saving the random number picked from the length of the list into the string variable index.
        int index = random.Next(_reflectQues.Count);
        string wrds = _reflectQues[index];
        Console.WriteLine(wrds); //question
    }
    public void displayQuesList(){
        foreach(var quest in _reflectLists){
                Thread.Sleep(5000);
                Console.WriteLine(quest);
                Console.WriteLine();
        }
    }
    public void reflect(){
        displayMessage();
        displaySpinner();
        displaRefQues();
        displayQuesList();
        // displaySpinner();
    }
}