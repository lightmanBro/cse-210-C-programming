public abstract class Activity
{

    protected string _name;
    protected double _lenght;
    protected double _speed;
    protected double _pace;
    protected double _mins;
    protected double _distance;
    protected string _date;


    public void setSpeed(double speed)
    {
        _speed = speed;
    }

    public void setPace(double pace){
        
        _pace = pace;
    }

    public void setDistance(double dist){
        _distance = dist;
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