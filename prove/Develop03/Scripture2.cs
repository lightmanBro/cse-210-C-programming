// using System;

// class Scripture
// {


//     private string _refrence;
//     private string _singleVerse;

//     public Scripture()
//     {
//         // default scripture to be displayed defined
//         _refrence = "John 3:16";
//         _singleVerse = "for God so loved the world that he gave his only begotten son and whosoever ...";

//     }

//     public Scripture(string refr, string singleV)
//     {
//         _refrence = refr;
//         _singleVerse = singleV;
//     }
//     // Initializing a list where all the scriptures will be stored

//     public void displayScripture(){
//         if(_singleVerse.Length < 100)
//         Console.WriteLine($"{_refrence} {_singleVerse}");
//         wordToList();
//         if(_singleVerse.Length > 100){
//             Console.WriteLine(_refrence);
//             Console.WriteLine(_singleVerse);
//         }
//     }
    
//     private void wordToList(){
//         char[] delimeter = { ' ' };
//         List<string> wordList = _singleVerse.Split(delimeter).ToList();
        
//         // create a random function and if the count random number is more that 1 then the number should e split into 2 then converted back into an int
//         // then in the loop, the list element in the position of the random number should be removed.
//         // string quit = Console.ReadLine();
//         // while (quit != "quit")
//         // {
            
//         // }
//             var random = new Random();
//             int index = random.Next(wordList.Count);
//             string wrds = wordList[index];
//             Console.WriteLine(_singleVerse.Replace(wrds,"___"));
//             Console.WriteLine(wordList[index] = "__");

        

//     }
//     public void loadFromExt()
//     {

//         Console.WriteLine("Enter Scripture Verse");
//         string filename = Console.ReadLine();
//         // method to read from the external file contents
//         string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");
//         // looping theough the contents of the file and printig it to the console.

//         foreach (string line in lines)
//         {
//             Console.WriteLine(line);
//         }

//     }








// }