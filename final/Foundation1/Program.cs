using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Feather on a clyde","Michael Resenberg",3.54);
        Video video2 = new Video("Let her go","Michael Resenberg",4.00);
        Video video3 = new Video("General Conference","The Church of Jesus Christ of Latter-Day Saints",55.43);
        Comments comment = new Comments();

        video1.addComentsToList(comment.addComments("Omotoso David","Wow such a nice song from the heart"));
        video1.addComentsToList(comment.addComments("Nathan Parrish","Wow ypu guys are really wonderful singers"));
        video1.addComentsToList(comment.addComments("Danny Buckrow","i will like to attend your gig"));

        video2.addComentsToList(comment.addComments("Jimmy Bush","I love this song so much"));
        video2.addComentsToList(comment.addComments("Omotoso Kehinde","I dedicate this song to my sister"));
        video2.addComentsToList(comment.addComments("Ayomide","I can feel the chills down my spine listening to this lyrics"));

        video3.addComentsToList(comment.addComments("Rodriguez","Such an inspiring talk from the leaders of The Church Of Jesus Christ"));
        video3.addComentsToList(comment.addComments("Antonio","I love elder Christopherson so much"));
        video3.addComentsToList(comment.addComments("Orlov","Really we need to see ourselves as children of God just as the apostles has admonished us all"));
        video3.addComentsToList(comment.addComments("Suraj Punjab","I know what the prophets are saying is very true and i know we will be blessed when we follow their admonishments"));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            //Call the display methods on all the videos in the video list.
            video.displayVideo();
        }
    }
}