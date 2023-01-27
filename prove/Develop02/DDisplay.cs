using System;
public class Display
{
    string _classname;
    string fileDirectory;
    public Display(string _classname){
        this._classname = _classname;
    }
public void ShowStoredData()
{
    fileDirectory = "entryData.txt";
    string[] lines = System.IO.File.ReadAllLines(fileDirectory);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        // string Question = parts[0];
        // string userResponse = parts[1];
        Console.WriteLine(line);
    }
}
}