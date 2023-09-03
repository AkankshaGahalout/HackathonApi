using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SEBI_APIs.Models
{
    public class SebiAlertsRequest
    {
        [Required]
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "alertDate")]
        public DateTime AlertDate { get; set; }

    }

    public class SebiAlertsResponse
    {
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "alertDate")]
        public DateOnly AlertDate { get; set; }

        [JsonProperty(PropertyName = "alertDetail")]
        public DateOnly AlertDetail { get; set; }

    }
}
