public class GratitudeActivity : Activity
{
    private List<string> _recipients;
    private List<int> _usedRecipients;

    public GratitudeActivity() 
        : base("Gratitude", "This activity will help you cultivate gratitude by writing a short letter of appreciation to someone in your mind. Focus on specific things you value about them.")
    {
        _recipients = new List<string>
        {
            "a family member who supported you",
            "a friend who made you laugh",
            "a teacher or mentor who believed in you",
            "a stranger who showed you kindness",
            "someone whose hard work inspires you",
            "a colleague who helped you recently"
        };
        _usedRecipients = new List<int>();
    }

    public void Run()
    {
        DisplayStartingMessage();

        string recipient = GetRandomRecipient();
        Console.WriteLine($"\nThink of {recipient}.");
        Console.WriteLine("Write a short gratitude note in your mind. Consider:");
        Console.WriteLine("  - What specific quality do you appreciate?");
        Console.WriteLine("  - How have they impacted your life?");
        Console.WriteLine("  - What would you say to them if they were here?\n");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Gratitude thought: ");
            Console.ReadLine();
        }

        Console.WriteLine("\nGratitude strengthens relationships and lifts the spirit.");
        DisplayEndingMessage();
    }

    private string GetRandomRecipient()
    {
        if (_usedRecipients.Count == _recipients.Count)
            _usedRecipients.Clear();

        int index;
        do
        {
            index = new Random().Next(_recipients.Count);
        } while (_usedRecipients.Contains(index));

        _usedRecipients.Add(index);
        return _recipients[index];
    }
}