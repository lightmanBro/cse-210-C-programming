public class Square:Shape{

    private double _sides;

    public Square(string color, double side): base(color){
        _sides = side;
        
    }

    public override double GetArea()
    {
        return _sides * _sides;
    }
}