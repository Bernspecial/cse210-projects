using System.Runtime.InteropServices;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
            "What time did you wake up this morning?", 
            "How long do you plan to stay at work today?",
            "What are your main to-do-lists for today?",
            "Do you have any plan of visiting friends today?",
            "Will you be going to work today?",
            "How did you spend your day today?",
            "Did you meet anybody today",
            "What made you happy today or what will make you happy toady?",
            "Have you read your scripture or to read when you are available?",
            "What was worst experience toady?",
            "What is the name of that friend you missed today?",
            "Do you plan to go to house of worship this Sunday?",
            "Have you called your Gf/Bf or Spouse today or plan to call later?",
            "What plan do you have for your free period today?",
            "Do you have anything to write down today and save for future purpose?",
            "Describe your day using car.",
            "Explain what you did best today.",
            "What is that thing you wished you didn't do today?",
            "Did you make any friends today. If yes, how many?",
            "What was the strongest emotion I felt today?",
            "How did I see the hand of the Lord in my life today?"
        };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int nextPrompt = random.Next(_prompts.Count);
        return _prompts[nextPrompt];
    }
}