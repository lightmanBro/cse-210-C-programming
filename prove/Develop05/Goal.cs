public abstract class Goals{

    private string _name;


    public Goals(string name){
        _name = name;
    }
    public virtual void setName(string name){

    }

    public virtual string getName(){
        return _name;
    }

    public abstract void recordEvents();

}