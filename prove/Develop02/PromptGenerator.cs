public class PromptGenerator{
    
    public List<string> _prompts = new List<string>(){

        "How did I feel the Spirit today?",
        "What was the most interesting part of my day?",
        "What made me happy today?",
        "How did I serve someone today? If I did not, who is someone you can serve and why?",
        "What was the hardest part about today?"

    };
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}