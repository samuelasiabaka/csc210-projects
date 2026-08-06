public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        bool inhale = true;

        while (DateTime.Now < endTime)
        {
            int remaining = (int)(endTime - DateTime.Now).TotalSeconds;
            int breathTime = Math.Min(4, remaining);

            if (inhale)
            {
                Console.WriteLine();
                ShowBreathingAnimation(breathTime, true);
                Console.WriteLine("Breathe in...");
                ShowCountDown(breathTime);
            }
            else
            {
                Console.WriteLine();
                ShowBreathingAnimation(breathTime, false);
                Console.WriteLine("Breathe out...");
                ShowCountDown(breathTime);
            }

            inhale = !inhale;
        }

        DisplayEndingMessage();
    }
}