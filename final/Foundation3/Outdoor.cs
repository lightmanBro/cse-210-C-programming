public class Outdoor:Event{
    private string _weatherInfo;

    public void getWeatherInfo(string weatherInfo){
        _weatherInfo = weatherInfo;  
    }

    public string fullDetails(){

        string fulldetails = $"Title: {_eventTitle}\nDescription: {_eventDesc}\nDate: {_eventDate}\nAddress: {_eventAddress}\nWeather Info\n: {_weatherInfo}";
        return fulldetails;
    }
    
}