using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OllamaLib.Models
{
    /// <summary>
    /// Represents the model details returned by the GetModels function.
    /// </summary>
    public class GetModel
    {
        public class Details
        {
            public string format { get; set; }
            public string family { get; set; }
            public object families { get; set; }
            public string parameter_size { get; set; }
            public string quantization_level { get; set; }
        }

        public class Model
        {
            public string name { get; set; }
            public string modified_at { get; set; }
            public object size { get; set; }
            public string digest { get; set; }
            public Details details { get; set; }
        }

        public class Root
        {
            public List<Model> models { get; set; }
        }
    }

    /// <summary>
    /// Represents the model used by the Chat function to send messages to the AI.
    /// </summary>
    public class ChatModel
    {
        public class Message
        {
            public string role { get; set; }
            public string content { get; set; }
            public object images { get; set; }
        }

        public class Root
        {
            public string model { get; set; }
            public string created_at { get; set; }
            public Message message { get; set; }
            public bool done { get; set; }
        }
    }

    /// <summary>
    /// Represents the data structure for sending chat messages to the API.
    /// </summary>
    public class ChatPostData
    {
        public class Message
        {
            public string role { get; set; }
            public string content { get; set; }
        }

        public class Root
        {
            public string model { get; set; }
            public List<Message> messages { get; set; }
        }
    }
}
