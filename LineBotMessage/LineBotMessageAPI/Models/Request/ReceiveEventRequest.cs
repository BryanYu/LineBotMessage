using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using LineBotMessageAPI.Models.Event;

namespace LineBotMessageAPI.Models.Request;

public class ReceiveEventRequest
{
    [JsonPropertyName("destination")]
    public string LineUserId { get; set; }
    
    [JsonPropertyName("events")]
    public EventContent[] Events { get; set; }
}