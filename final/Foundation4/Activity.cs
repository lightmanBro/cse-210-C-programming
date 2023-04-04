public abstract class Activity
{

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

    public void setDistance(double distance)
    {
        _distance = distance;
    }

    public void setSpeed(double speed)
    {
        _speed = speed;
    }

    public void setPace(double pace){
        
        _pace = pace;
    }
    public virtual double getDistance()
    {
        return _distance;
    }

    public virtual double getSpeed(){
        return _speed;
    }

    public virtual double getPace()
    {
        return _pace;
    }

}