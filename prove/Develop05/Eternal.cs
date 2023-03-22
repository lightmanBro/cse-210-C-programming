public class Eternal:Goals{

    private string _ev = "Eternal";
    public Eternal(string desc,string name,int points):base(name,desc,points){}
    public override string recordEvents(){
        return "Eternal";
        }
}