public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random r = new Random( );
        int index = r.Next( _prompts.Count );
        string randomString = _prompts[ index ];

        return randomString;

    }
}