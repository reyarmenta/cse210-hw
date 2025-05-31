public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What would you have done differently today?",
        "What did you do today?",
        "What was the best part of your day?",
        "What was somethign new you did today?",
        "Was there something difficult today?",
        "What is somethign you'd like to remember from today?",
        "What did you learn today?",
        "Who did you talk to today",
        "What scripture did you read today?",
        "What feeling or impressions did you have today"
    };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

}