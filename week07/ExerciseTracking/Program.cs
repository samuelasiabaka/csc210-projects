using System;

class Program
{
    static void Main(string[] args)
    {
        // Create at least one activity of each type
        Running run1 = new Running("03 Aug 2026", 30, 4.8);
        Cycling cycle1 = new Cycling("04 Aug 2026", 45, 20.0);
        Swimming swim1 = new Swimming("05 Aug 2026", 40, 30);

        // Put each activity in the same list
        List<Activity> activities = new List<Activity>();
        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swim1);

        // Iterate through the list and display the summary for each
        Console.WriteLine("Exercise Activity Summaries");
        Console.WriteLine("------------------");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
    }
}