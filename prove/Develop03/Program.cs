using System;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scipture");


        Refrence refrence = new Refrence("matt",5,3);
        string r = refrence.refVerseToString();
        Console.WriteLine(r);

        Scripture scripture = new Scripture();
        scripture.displayScripture();
        





        // string verse1 = "prov 3:4";
        // string proverb = "for God so love the world that he gave his only begotten .......";
        // string verse2 = "matt 5:6";
        // string matt = "In the beginning......";

        // Entry newEnt = new Entry();
        // Entry newEnt2 = new Entry();

        // // first style
        // newEnt.addScripture(verse1,proverb);
        // newEnt.addScripture(verse2,matt);
        // newEnt.displayQ();

        // // second style
        // newEnt2.addScripture2(verse1,proverb);
        // newEnt2.addScripture2(verse2,matt);
        // newEnt2.displayQ2();
        

        // // third style
        // string refr = newEnt.addRef(proverb);
        // string vrse = newEnt.addVerse(verse1);
        // Scripture src = new Scripture();

        // // fourth style
        // string[] srcEnt = {
        //         refr,
        //         vrse
        //     };
        // src._addScripture.AddRange(srcEnt);
        // src.displayScripture();

        
    }



}