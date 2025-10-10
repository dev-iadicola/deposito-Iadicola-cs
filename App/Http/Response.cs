using System.Text;
using System.Text.Json;

namespace FirstProject.App.Http;

public class Response
{
    public int StatusCode { get; set; } = 200;
    public string ContentType { get; set; } = "text/html";
    public string Body { get; set; } = "";

    // 🔹 Metodo helper per creare risposta JSON
    public static Response Json(object data, int statusCode = 200)
    {
        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        return new Response
        {
            StatusCode = statusCode,
            ContentType = "application/json",
            Body = json
        };
    }

    public byte[] GetBytes() => Encoding.UTF8.GetBytes(Body);
}
