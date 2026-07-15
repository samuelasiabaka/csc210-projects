using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;
        Journal journal = new Journal();

        do
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
                promptGenerator._prompts.Add("What was the best part of my day?");
                promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
                promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
                promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");
                promptGenerator._prompts.Add("What is consuming most of your mental energy today, and why?");
                promptGenerator._prompts.Add("What is the smallest step you can take tomorrow toward your biggest goal?");

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                entry._promptText = prompt;
                string entryText = Console.ReadLine();
                entry._entryText = entryText;

                journal._entries.Add(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                journal.DisplayAll();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        while (choice != 5);
    }
}