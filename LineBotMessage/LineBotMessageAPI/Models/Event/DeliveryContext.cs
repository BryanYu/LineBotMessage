using System.Text.Json.Serialization;

namespace LineBotMessageAPI.Models.Event;

public class DeliveryContext
{
    [JsonPropertyName("isRedelivery")]
    public bool IsRedelivery { get; set; }
}