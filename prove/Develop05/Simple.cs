public class Simple:Goals{

    private string _goalName = "Simple";
    public override void display()
    {
        Console.WriteLine($"{_goalName}, {this.getName()}, {this.getDesc()}");
    }
    public override string recordEvents(){

        // this record event should take in the new point allocated and set it as the gained point then add it to the total points.
        return "Eternal";
        }
}