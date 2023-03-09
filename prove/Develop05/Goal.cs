public abstract class Goals{

    private string _name;

    private string _description;
    private string _points;
    public Goals(string name,string desc, string points){
        _name = name;
        _description = desc;
        _points = points;
    }
    public virtual void setName(string name){

    }

    public virtual string getName(){
        return _name;
    }

    public abstract void recordEvents();

}