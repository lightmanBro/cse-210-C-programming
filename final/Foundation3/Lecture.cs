public class Lecture:Event{

    private string _speaker;
    private int _capacity;

    public string fullDetails(){

        string fulldetails = $"Title: {_eventTitle}\nDescription: {_eventDesc}\nDate: {_eventDate}\nAddress: {_eventAddress}\nSpeaker: {_speaker}\nCapacity {_capacity}";
        return fulldetails;
    }
}