using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Running run = new Running(DateTime.Now, 30, 4.8);
        System.Console.WriteLine(run.GetSummary());
        Biking bk = new Biking(DateTime.Now, 25, 38.7);
        System.Console.WriteLine(bk.GetSummary());
        Swimming sw = new Swimming(DateTime.Now, 60, 25);
        System.Console.WriteLine(sw.GetSummary());
        System.Console.WriteLine();

        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(bk);
        activities.Add(sw);

        foreach (var item in activities)
        {
            System.Console.WriteLine(item.GetSummary());
            
        }
    }
}