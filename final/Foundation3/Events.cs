public class Event{
    private string _eventTitle;
    private string _eventDesc;
    private string _eventDate;
    private string _eventAddress;


    public string standardDetails(){
        string details = $"Event: {_eventTitle}\n{_eventDesc}\n{_eventDate}\n{_eventAddress}";
        return details;
    }
}