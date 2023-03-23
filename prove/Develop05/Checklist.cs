public class Checklist:Goals{

    private int _bonusTime;
    private int _accomplishBonus;
    private int _completedTime = 0;

    public Checklist(string desc,string name,int points,int _bonusTime, int _accomplishBonus):base(name,desc,points){
    }
    
    public override void display()
    {
        Console.WriteLine($"{this.getName()}, {this.getDesc()} {this.getCompletedTime()}");
    }

    public override int getCompletedTime(){
        return _completedTime;
    }
    public override string recordEvents()
    {
        return "Okay";
    }
}