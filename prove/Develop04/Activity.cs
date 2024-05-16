public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
public Activity()
{
    _name="";
    _description="";
    _duration=0;
}
public void DisplayStartingMessage()
{
    Console.Clear();

    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine("");
    Console.WriteLine(_description);
    Console.WriteLine("");
    Console.WriteLine("How long, in seconds, would you like this session to last?");

    string response = Console.ReadLine();
    _duration = int.Parse(response);

    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(5);
    Console.Clear();
    Console.WriteLine("");
}
public void DisplayEndingMessage()
{
    
    Console.WriteLine("Well done!");
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    ShowSpinner(5);
    Console.Clear();
    
}
public void ShowSpinner(int seconds)
{
    DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(seconds);

    int cursorLeft = Console.CursorLeft;
    int cursorTop = Console.CursorTop;

    char[] spinnerCharacters = {'-', '\\', '|', '/'};
    
    do 
    {
        foreach(char character in spinnerCharacters)
        {
            Console.SetCursorPosition(cursorLeft,cursorTop);
            Console.Write(character);

            Thread.Sleep(200);
        }
    }
    while (DateTime.Now < stopTime);

    
}
public void ShowCountDown(int seconds)
{
    int cursorLeft = Console.CursorLeft;
    int cursorTop = Console.CursorTop;

    for(int i = seconds; i>0; i--)
    {
        
        Console.SetCursorPosition(cursorLeft,cursorTop);

        Console.Write(i);
        Thread.Sleep(1000);
    }
    Console.SetCursorPosition(cursorLeft,cursorTop);
    Console.Write(" ");
    
}

}