using System.Diagnostics;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

static async Task SerializeAsyncEnumerable()
{
    var options = new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles };
    using Stream stream = Console.OpenStandardOutput();
    var data = new { Data = PrintNumbers(3) };
    await JsonSerializer.SerializeAsync(stream, data); // prints {"Data":[0,1,2]}
    Console.WriteLine();
}

static async IAsyncEnumerable<int> PrintNumbers(int n)
{
    for (int i = 0; i < n; i++) yield return i;
}

static void WritableDom()
{
    // Parse a JSON object
    JsonNode jNode = JsonNode.Parse("{\"MyProperty\":42}");

    jNode["MyProperty"] = "43";
    Console.WriteLine(jNode.ToJsonString());

    // Create a new JsonObject using object initializers and array params
    var jObject = new JsonObject
    {
        ["MyChildObject"] = new JsonObject
        {
            ["MyProperty"] = "Hello",
            ["MyArray"] = new JsonArray(10, 11, 12)
        }
    };

    string json = jObject.ToJsonString();
    Console.WriteLine(json);
}

static void SourceGenSerializationMethod1()
{
    // this is generally fastest
    var message = new MessageObject { Message = "this is a message" };

    using MemoryStream ms = new();
    using Utf8JsonWriter writer = new(ms);

    SerializationContext.Default.MessageObject.Serialize(writer, message);
    writer.Flush();

    Console.WriteLine(System.Text.Encoding.UTF8.GetString(ms.ToArray()));

    // alternative
    JsonSerializer.Serialize(message, SerializationContext.Default.MessageObject);

    // alternative alternative
    JsonSerializer.Serialize(message, typeof(MessageObject), SerializationContext.Default);
}

static void SourceGenSerializationMethod2()
{
    var message = new MessageObject { Message = "this is a message" };

    // alternative
    JsonSerializer.Serialize(message, SerializationContext.Default.MessageObject);

    // alternative alternative
    JsonSerializer.Serialize(message, typeof(MessageObject), SerializationContext.Default);
}

static void SourceGenSerializationMethod3()
{
    var message = new MessageObject { Message = "this is a message" };

    // alternative alternative
    JsonSerializer.Serialize(message, typeof(MessageObject), SerializationContext.Default);
}

static void SourceGenDeserialization()
{
    var message = new MessageObject { Message = "this is a message" };

    // alternative alternative
    var json = JsonSerializer.Serialize(message, typeof(MessageObject), SerializationContext.Default);
    var message2 = JsonSerializer.Deserialize(json, SerializationContext.Default.MessageObject);
    Debug.Assert(message.Message == message2.Message);

}

await SerializeAsyncEnumerable();
WritableDom();

SourceGenSerializationMethod1();
SourceGenSerializationMethod2();
SourceGenSerializationMethod3();

SourceGenDeserialization();



Console.ReadLine();
