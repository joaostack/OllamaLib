using OllamaLib.Models;
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
        void SetModel(string model);
        Task<string> Chat(string role, string message);
        Task<List<GetModel.Model>> GetModels();
    }
}
