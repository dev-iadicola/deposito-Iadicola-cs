using System.Net;
using System.Collections.Concurrent;
using System.IO;

namespace FirstProject.App.Http;

public class Router
{
    private readonly HttpListener listener = new();
    private readonly ConcurrentDictionary<string, Func<Response>> routes = new();

    // 🔹 percorso base per i file statici
    private readonly string staticFolder;

    public Router(string prefix = "http://localhost:8080/", string staticPath = "client")
    {
        listener.Prefixes.Add(prefix);
        staticFolder = Path.Combine(Directory.GetCurrentDirectory(), staticPath);
    }

    public void Get(string path, Func<Response> handler)
    {
        routes[path] = handler;
    }

    public async Task StartAsync()
    {
        listener.Start();
        Console.WriteLine("✅ Server avviato su http://localhost:8080");

        while (true)
        {
            var context = await listener.GetContextAsync();
            string path = context.Request.Url?.AbsolutePath ?? "/";
            Console.WriteLine($"→ {path}");

            // CORS
            context.Response.AddHeader("Access-Control-Allow-Origin", "*");
            context.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
            context.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type");

            // 🔹 Gestione file statici
            if (await TryServeStaticFile(context, path))
                continue;

            // 🔹 Gestione API definite con router.Get()
            if (routes.TryGetValue(path, out var handler))
            {
                var res = handler();
                context.Response.StatusCode = res.StatusCode;
                context.Response.ContentType = res.ContentType;
                byte[] buffer = res.GetBytes();
                await context.Response.OutputStream.WriteAsync(buffer);
            }
            else
            {
                var notFound = Response.Json(new { error = "Not Found" }, 404);
                context.Response.StatusCode = notFound.StatusCode;
                context.Response.ContentType = notFound.ContentType;
                await context.Response.OutputStream.WriteAsync(notFound.GetBytes());
            }

            context.Response.Close();
        }
    }

    // 🔹 Metodo per servire file statici
    private async Task<bool> TryServeStaticFile(HttpListenerContext context, string path)
    {
        // default: / → index.html
        if (path == "/") path = "/index.html";

        string filePath = Path.Combine(staticFolder, path.TrimStart('/'));

        if (File.Exists(filePath))
        {
            string contentType = GetContentType(Path.GetExtension(filePath));
            byte[] buffer = await File.ReadAllBytesAsync(filePath);

            context.Response.StatusCode = 200;
            context.Response.ContentType = contentType;
            await context.Response.OutputStream.WriteAsync(buffer);
            context.Response.Close();
            return true;
        }

        return false;
    }

    private string GetContentType(string ext)
    {
        return ext switch
        {
            ".html" => "text/html",
            ".css" => "text/css",
            ".js" => "application/javascript",
            ".json" => "application/json",
            ".png" => "image/png",
            ".jpg" or ".jpeg" => "image/jpeg",
            ".svg" => "image/svg+xml",
            _ => "application/octet-stream"
        };
    }
}
