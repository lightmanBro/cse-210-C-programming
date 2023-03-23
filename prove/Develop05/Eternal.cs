public class Eternal:Goals{

    private string _goalName= "Eternal";
    public Eternal(string desc,string name,int points):base(name,desc,points){
    }

    private string goalName(){
        return _goalName;
    }
    public override void display()
    {
        Console.WriteLine($"{_goalName} {this.getName()}, {this.getDesc()}, {this.getPoints()}");
    }
    public override string recordEvents(){
        return "Eternal";
        }
}