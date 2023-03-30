public class Reception:Event{

    private string _rsvpEmail;
    private string _register;

    //Ask if the user wants to rsvp, if true then the user will have to provide name and phone number.
    public void setRsvpEmail(string rsvpemail){

        _rsvpEmail = rsvpemail;
    }
}