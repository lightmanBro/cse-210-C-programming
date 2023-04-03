public class Activity{

    private string _name;
    private double _distance;
    private double _speed;
    private double _pace;
    private string date;

    public string summary()
    {
        string summ = $"{date} ({_name})- Distance {_distance} miles, {_speed} {_pace} min per mile";
        return summ;
    }

    public double getDistance(){
        return _distance;
    }

    public double getSpeed(){
        return _speed;
    }

    public double getPace(){
        return _pace;
    }

}