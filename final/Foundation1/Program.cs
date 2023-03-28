using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Feather on a clyde","Michael Resenberg",3.54);
        Comments comment1 = new Comments();

        video1.addComentsToList(comment1.addComments("Omotoso David","Wow such a nice song from the heart"));
        video1.addComentsToList(comment1.addComments("Nathan Parrish","Wow ypu guys are really wonderful singers"));
        video1.addComentsToList(comment1.addComments("Danny Buckrow","i will like to attend your gig"));

        video1.displayVideo();
    }
}