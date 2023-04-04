public class Running:Activity{

    private int _distance;


    public override double getDistance()
    {
         _distance= _numberOfLap * 50/1000;
         return _distance;
    }
    public override double getSpeed()
    {
        _speed = getDistance()/_mins;
        return _speed;
    }
    public override double getPace()
    {
        _pace = _mins / _distance;
        return _pace;
    }
    public override string GetSummary()
    {
        
    }
}