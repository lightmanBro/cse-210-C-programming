public class Simple:Goals{

    private string _goalName = "Simple";
    public Simple(string desc,string name,int points):base(name,desc,points){
    }

    public override void display()
    {
        Console.WriteLine($"{_goalName}, {this.getName()}, {this.getDesc()}");
    }
    public override string recordEvents()
    {
        return $"{_goalName}";
    }
}