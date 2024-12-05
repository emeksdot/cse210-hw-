using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> _videos = new List<Video>();
        Video vid1 = new Video("Essential Pots", "Kitchen Appliances", 188);
        Video vid2 = new Video("Rice Cooker", "", 236);
        Video vid3 = new Video("Digital Alarms", "Aquatica", 197);
        Video vid4 = new Video("L.E.D. Projector", "Mildred Electronics", 125);

        Comment vid1com1 = new Comment("Paul", "Great Product, nice look too.");
        Comment vid1com2 = new Comment("Mike", "The price looks tempting.");
        Comment vid1com3 = new Comment("Bob", "The price looks tempting.");

        Comment vid2com1 = new Comment("Jo", "I will definitely try this");
        Comment vid2com2 = new Comment("Betty", "I need a rice cooker");
        Comment vid2com3 = new Comment("Gladys", "Does it have 6 liter version?");

        Comment vid3com1 = new Comment("Chris", "Rings so loud, Will ");
        Comment vid3com2 = new Comment("Taju", "will try this");
        Comment vid3com3 = new Comment("Chinwe", "I don't have a bedside table, can it go on the wall?");

        Comment vid4com1 = new Comment("Kim", "I love the bluetooth capability.");
        Comment vid4com2 = new Comment("Johnson", "Does it have inbuilt speakers?");
        Comment vid4com3 = new Comment("James", "Does it also use WiFi");
        Comment vid4com4 = new Comment("Bradley", "Good visuals");

        System.Console.WriteLine(_videos.Count);
        vid1.GetListOfComments().Add(vid1com1);
        vid1.GetListOfComments().Add(vid1com2);
        vid1.GetListOfComments().Add(vid1com3);

        vid2.GetListOfComments().Add(vid2com1);
        vid2.GetListOfComments().Add(vid2com2);
        vid2.GetListOfComments().Add(vid2com3);

        vid3.GetListOfComments().Add(vid3com1);
        vid3.GetListOfComments().Add(vid3com2);
        vid3.GetListOfComments().Add(vid3com3);

        vid4.GetListOfComments().Add(vid4com1);
        vid4.GetListOfComments().Add(vid4com2);
        vid4.GetListOfComments().Add(vid4com3);
        vid4.GetListOfComments().Add(vid4com4);
        System.Console.WriteLine(vid1.GetListOfComments().Count);

        _videos.Add(vid1);
        _videos.Add(vid2);
        _videos.Add(vid3);
        _videos.Add(vid4);

        int numberOfComments = 0;

        foreach (var video in _videos)
        {
                System.Console.WriteLine($"Title: {video.GetTitle()}- Author: {video.GetAuthor()}- Length: {video.GetLength()}");            
            foreach (var item in video.GetListOfComments())
            {    
                System.Console.WriteLine($"{item.GetText()}\nby {item.GetName()} \n ");
                numberOfComments++;
            }
            
        }
        System.Console.WriteLine(numberOfComments);
    }
}