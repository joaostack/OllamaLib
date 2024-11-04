using OllamaLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OllamaLib.Repositories
{
    public class OllamaRepository
    {
        private static HttpClient _httpClient = new HttpClient();
        private static string _apiUrl = "http://localhost:11434";
        private static string _model = "";

        /// <summary>
        /// Set Ollama API url
        /// <param name="apiUrl">Ollama api url, default is http://localhost:11434.</param>
        /// </summary>
        public static void SetApi(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public static void SetModel(string model)
        {
            _model = model;
        }

        /// <summary>
        /// Sends a chat message to the AI model and retrieves the response asynchronously.
        /// </summary>
        /// <param name="role">The role of the message sender, such as "user" or "assistant".</param>
        /// <param name="message">The content of the message to be sent to the AI model.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response from the AI model as a string.</returns>
        public static async Task<string> Chat(string role, string message)
        {
            var chatPostData = new ChatPostData.Root()
            {
                model = _model,
                messages = new List<ChatPostData.Message>
                {
                    new ChatPostData.Message
                    {
                        role = role,
                        content = message
                    }
                }
            };

            string chatPostDataJson = JsonSerializer.Serialize(chatPostData);
            var finalPostData = new StringContent(chatPostDataJson, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await _httpClient.PostAsync($"{_apiUrl}/api/chat", finalPostData);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
