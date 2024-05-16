public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost today?", 
        "Who are some of your personal heroes?", 
        "What are you grateful for today?", 
        "How have you seen God's hand in your life this month?"

    };


public ListingActivity()
{
    _name = "Listing Activity";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
}

public void Run()
{
    

    DisplayStartingMessage();

    Console.WriteLine("List as many responses as you can to the following prompt:");
    Console.WriteLine("");
    Console.Write("--- ");
    GetRandomPrompt();
    Console.WriteLine("---");
    Console.WriteLine("");

    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.WriteLine("");

    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_duration);

    

    do
    {
        string userResponse = Console.ReadLine();

        if (userResponse != null)
        {
            _count++;
        }
    }
    while (DateTime.Now < stopTime);
    
    Console.WriteLine($"You listed {_count} items!");


    DisplayEndingMessage();
    
    
}
public void GetRandomPrompt()
{
    Random random = new Random();
    
    int randomIndex = random.Next(_prompts.Count);

    Console.Write(_prompts[randomIndex]);

}
public List<string> GetListFromUser()
{
    return _prompts;

}
public void InitializePrompts()
{
    
}

}