using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OllamaLib.Repositories
{
    public class OllamaRepository
    {
        private static HttpClient _httpClient = new HttpClient();
        private static string _apiUrl = "http://localhost:11434";

        /// <summary>
        /// Set Ollama API url (http://localhost:11434 is default)
        /// </summary>
        public static void SetApi(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public static async Task<string> Chat(string message)
        {
            var chatPostData = new
            
            using HttpResponseMessage response = await _httpClient.PostAsync($"{apiUrl}/api/chat");
        }
    }
}
