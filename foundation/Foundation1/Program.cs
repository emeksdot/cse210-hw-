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
    }
}