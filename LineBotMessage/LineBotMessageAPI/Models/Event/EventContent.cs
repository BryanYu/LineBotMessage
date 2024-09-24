using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using LineBotMessageAPI.Models.Enum;

namespace LineBotMessageAPI.Models.Event;

public class EventContent
{
    [JsonPropertyName("type")]
    public EventType Type { get; set; }
    
    [JsonPropertyName("mode")]
    public EventMode Mode { get; set; }
    
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }
    
    [JsonPropertyName("source")]
    public JsonObject Source { get; set; }
    
    [JsonPropertyName("webhookEventId")]
    public string WebhookEventId { get; set; }
    
    [JsonPropertyName("deliveryContext")]
    public DeliveryContext DeliveryContext { get; set; }
    
    [JsonPropertyName("message")]
    public JsonElement Message { get; set; }
    
}


