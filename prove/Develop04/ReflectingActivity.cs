public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>{
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

    private List <string> _remainingQuestions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity.";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _remainingQuestions = new List<string>(_questions);
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine("--- " + GetRandomPrompt() + " ---");
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.WriteLine("");

        
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {

        }
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");


        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        Console.Clear();

        do
        {
            
            Console.Write(GetRandomQuestion());
            ShowSpinner(5);
            Console.Clear();
        }
        while(DateTime.Now < stopTime);



        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }
    public string GetRandomQuestion()
    {
        if(_remainingQuestions.Count ==0)
        {
            _remainingQuestions = new List<string>(_questions);
        }
        Random random = new Random();
        int randomIndex = random.Next(_remainingQuestions.Count);

        string currentQuestion = _remainingQuestions[randomIndex];
        _remainingQuestions.RemoveAt(randomIndex);

        return currentQuestion;
        
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {
        
    }

}