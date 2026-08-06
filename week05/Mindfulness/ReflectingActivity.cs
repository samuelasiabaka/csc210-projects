public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _usedPrompts;
    private List<int> _usedQuestions;

    public ReflectingActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _usedPrompts = new List<int>();
        _usedQuestions = new List<int>();
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(8);
            Console.WriteLine();
        }

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

    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
            _usedQuestions.Clear();

        int index;
        do
        {
            index = new Random().Next(_questions.Count);
        } while (_usedQuestions.Contains(index));

        _usedQuestions.Add(index);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}