public class Eternal:Goals{

    
    public override void display()
    {
        Console.WriteLine($"{this.getName()}, {this.getDesc()}, {this.getPoints()}");
    }
    public override string recordEvents(){

        // this record event should take in the new point allocated and set it as the gained point then add it to the total points.
        return "Eternal";
        }
}