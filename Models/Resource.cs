using Newtonsoft.Json;

namespace LandonAPI2.Models
{
    public abstract class Resource
    {
        [JsonProperty(Order = -2)]
        public string Href { get; set; }
    }
}
