public class ActivityLog
{
    private Dictionary<string, int> _stats;

    public ActivityLog()
    {
        _stats = new Dictionary<string, int>
        {
            { "Breathing", 0 },
            { "Reflecting", 0 },
            { "Listing", 0 },
            { "Gratitude", 0 }
        };
    }

    public void LogActivity(string activityName)
    {
        if (_stats.ContainsKey(activityName))
            _stats[activityName]++;
    }

    public void DisplayStats()
    {
        Console.Clear();
        Console.WriteLine("=== Activity Statistics ===\n");
        int total = 0;
        foreach (var entry in _stats)
        {
            Console.WriteLine($"{entry.Key,-12}: {entry.Value} session(s)");
            total += entry.Value;
        }
        Console.WriteLine($"\nTotal sessions: {total}");
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}