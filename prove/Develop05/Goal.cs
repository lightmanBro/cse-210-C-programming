public abstract class Goals{

    private string _name;

    private string _description;
    private int _points;
    public Goals(string name,string desc, int points){
        _name = name;
        _description = desc;
        _points = points;
    }
    public virtual void setName(string name){

    }

    public virtual string getName(){
        return _name;
    }
    public virtual string getDesc(){
        return _description;
    }

    public virtual string getPoints(){
        return _name;
    }
    public abstract void recordEvents();

}