using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OllamaLib.Interfaces
{
    public interface IOllama
    {
        void SetApi(string apiUrl);
        Task<string> Chat(string message);
        Task<List<string>> GetModels();
    }
}
