public abstract class Shape{

    private string _color;


    public Shape(string color){
        _color = color;
    }
    public virtual string GetColor(){
        return _color;
    }
    public virtual void SetColor(string color){

    }

    // this is abstract because its the derived class that will modify it based on their member variable values.
    public abstract double GetArea();
}