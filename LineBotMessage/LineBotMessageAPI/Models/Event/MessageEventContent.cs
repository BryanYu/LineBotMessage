using System.Text.Json.Serialization;

namespace LineBotMessageAPI.Models.Event;

public class MessageEventContent
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    [JsonPropertyName("quoteToken")]
    public string QutoeToken { get; set; }
    
    [JsonPropertyName("text")]
    public string Text { get; set; }
}