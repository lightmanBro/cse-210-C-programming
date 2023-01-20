
public class Job 
{
    public string _company, _jobTitle;
    public int _startYear, _endYear;

    public Job(string _company,string _jobTitle, int _startYear, int _endYear){
        this._company = _company;
        this._jobTitle = _jobTitle;
        this._startYear = _startYear;
        this._endYear = _endYear;
    }

    public void DisplayJob(){
        Console.WriteLine($"{this._jobTitle} ({this._company}) {this._startYear}-{this._endYear}");
    }
}