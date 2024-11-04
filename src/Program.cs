using OllamaLib.Repositories;

class Program
{
    static async Task Main()
    {
        OllamaRepository.SetApi("http://localhost:11434");
        OllamaRepository.SetModel("qwen2.5:0.5b");

        string role = "user";
        string content = "Hello, how are you?";

        try
        {
            string response = await OllamaRepository.Chat(role, content);
            Console.WriteLine("Response from AI: " + response);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.WriteLine("\nModels:");

        var models = await OllamaRepository.GetModels();
        foreach (var model in models)
        {
            Console.WriteLine(model.name);
        }
    }
}