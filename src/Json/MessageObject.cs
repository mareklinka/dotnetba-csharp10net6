using System.Text.Json.Serialization;

namespace Json
{
    public class MessageObject
    {
        public string Message { get; set; }
    }

    [JsonSerializable(typeof(MessageObject))]
    public partial class SerializationContext : JsonSerializerContext
    {

    }
}

