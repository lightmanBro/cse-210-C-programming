public abstract class Goals{

    private string _name;

    private string _description;
    private int _points;
    private int _completedTime;

    public Goals(){ }
    public virtual void setName(string name){

    }
    public void setCompletedTime(int t){
        _completedTime = t;
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

    public virtual int getCompletedTime(){
        return _completedTime;
    }
    public abstract void display();
    public abstract string recordEvents();

}