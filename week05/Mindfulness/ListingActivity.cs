public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<int> _usedPrompts;

    public ListingActivity() 
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _usedPrompts = new List<int>();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
            _usedPrompts.Clear();

        int index;
        do
        {
            index = new Random().Next(_prompts.Count);
        } while (_usedPrompts.Contains(index));

        _usedPrompts.Add(index);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        // Helper method if needed for future extensions
        return new List<string>();
    }
}