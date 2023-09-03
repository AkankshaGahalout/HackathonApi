using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SEBI_APIs.Models
{
    public class Learn
    {
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
