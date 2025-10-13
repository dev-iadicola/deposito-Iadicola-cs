// using System.Net.WebSockets;
// using System.Security.Cryptography.X509Certificates;
// using FirstProject.App.Entity;
// using FirstProject.App;
// using FirstProject.App.Helpers.Array;
// using FirstProject.App.Helpers.Str;
// using FirstProject.App.IO;
// using FirstProject.App.Terminal;
// using FirstProject.App.Entity.Base;
// using FirstProject.App.Http;

// class Web
// {

//     static async Task Main()
//     {
//         var router = new Router();

//         router.Get("/", () =>
//         {
//             string htmlPath = Path.Combine(Directory.GetCurrentDirectory(), "client", "index.html");
//             string html = File.ReadAllText(htmlPath);
//             return new Response
//             {
//                 ContentType = "text/html",
//                 Body = html
//             };
//         });
//         router.Get("/animali", () => Response.Json(new
//         {
//             success = true,
//             data = new[] {
//                 new { tipo = "cane", nome = "Rex", eta = 7 },
//                 new { tipo = "gatto", nome = "Fyf", eta = 4 }
//             }
//         }));

//         await router.StartAsync();
//     }


// }