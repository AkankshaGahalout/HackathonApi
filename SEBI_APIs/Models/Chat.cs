using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SEBI_APIs.Models
{
    public class ChatRequest
    {
        [Required]
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

    }

    public class ChatResponse
    {
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }

    }
}
