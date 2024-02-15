// Define a public class "PromptText"
public class PromptText
{
    // Declare a private list field "_prompts" to store a list of prompts
    private List<string> _prompts = new List<string> {
        // Initialize the list with some prompts
        "What's something you're grateful for today?",
        "What's a challenge you're facing right now?",
        "What's a goal you'd like to achieve in the next month?",
        "What's a piece of advice you'd give to a younger version of yourself?",
        "What's a lesson you've learned from a recent experience?",
        "What's a fun fact you've discovered today?",
        "What's a quote you find inspiring?",
        "What's a recent accomplishment you're proud of?",
        "What's a habit you'd like to start or continue?",
        "What's a skill you'd like to learn or improve?"
    };

    // Define a method "GetRandomPrompt" that returns a random prompt from the list
    public string GetRandomPrompt()
    {
        // Create a new instance of the "Random" class
        Random random = new Random();

        // Generate a random index for the prompt list
        int nextPrompt = random.Next(_prompts.Count);

        // Return the prompt at the random index
        return _prompts[nextPrompt];
    }

}