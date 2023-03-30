public class Event{
    protected string _eventTitle;
    protected string _eventDesc;
    protected string _eventDate;
    protected string _eventAddress;

    public void setAddress(string add){
        _eventAddress = add;
    }
    public string standardDetails(){
        string details = $"Event: {_eventTitle}\n{_eventDesc}\n{_eventDate}\n{_eventAddress}";
        return details;
    }
}