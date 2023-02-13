using System;

class Scripture
{


    private string _refrence;
    private string _singleVerse;



    public Scripture()
    {
        // default scripture to be displayed defined
        _refrence = "John 3:16";
        _singleVerse = "for God so loved the world that he gave his only begotten son and whosoefor God so loved the world that he gave his only begotten son and whosoeverfor God so loved the world that he gave his only begotten son and whosoever ... ...for God so loved the world that he gave his only begotten son and whosoever ...ver for God so loved the world that he gave his only begotten son and whosoever ...... for God so loved the world that he gave his only begotten son and whosoever ...";

    }

    public Scripture(string refr, string singleV)
    {
        _refrence = refr;
        _singleVerse = singleV;
    }
    // Initializing a list where all the scriptures will be stored

    public void displayScripture(){
        if(_singleVerse.Length < 100)
        Console.WriteLine($"{_refrence} {_singleVerse}");
        if(_singleVerse.Length > 100){
            Console.WriteLine(_refrence);
            Console.WriteLine(_singleVerse);
        }
    }
    

    //    public void displayScripture(){
    //        var random = new Random();
    //       int index = random.Next(_addScripture.Count);
    //       Console.WriteLine(_addScripture[index]);






    public void loadFromExt()
    {

        Console.WriteLine("Please Enter file name to see the contents");
        string filename = Console.ReadLine();
        // method to read from the external file contents
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");
        // looping theough the contents of the file and printig it to the console.
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
}