public class BreathingActivity : Activity
{

public BreathingActivity()
{
    _name = "Breathing Activity.";
    _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    
}
public void Run()
{
    DisplayStartingMessage();

    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);

    do
    {
        Console.Write("Breathe in... ");
        ShowCountDown(5);
        Console.WriteLine("");
        
        Console.Write("Breathe out... ");
        ShowCountDown(5);
        Console.WriteLine("");
    }
    while (DateTime.Now < stopTime);

    DisplayEndingMessage();
}

}