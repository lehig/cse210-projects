using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Activity run = new Running("31 March 2023", 60, 4);
        activities.Add(run);
        Activity bike = new Cycling("23 February 2023", 24, 10.5);
        activities.Add(bike);
        Activity swim = new Swimming("23 January 2023", 81, 100);
        activities.Add(swim);

        foreach(Activity act in activities){
            Console.WriteLine(act.GetSummary());
        }
    }
}