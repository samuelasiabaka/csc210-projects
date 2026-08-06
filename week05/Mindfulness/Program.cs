using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        ActivityLog log = new ActivityLog();

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. View Activity Statistics");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    log.LogActivity("Breathing");
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    log.LogActivity("Reflecting");
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    log.LogActivity("Listing");
                    break;
                case "4":
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    log.LogActivity("Gratitude");
                    break;
                case "5":
                    log.DisplayStats();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("\nStay mindful and a great day!");
                    Thread.Sleep(1500);
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}