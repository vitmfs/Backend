using Microsoft.Extensions.Primitives;

namespace ASPNETCoreEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            // first middleware
            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                if (1 == 1)
                {
                    context.Response.StatusCode = 200;
                }
                else
                {
                    //context.Response.StatusCode = 400;
                }

                string path = context.Request.Path;

                context.Response.Headers["MyKey"] = "My Value";
                context.Response.Headers["Content-Type"] = "text/html";

                if (context.Request.Method == "GET")
                {
                    if (context.Request.Query.ContainsKey("id"))
                    {
                        string? id = context.Request.Query["id"];
                        await context.Response.WriteAsync($"<p>ID: {id}<p>");
                    }
                }

                if (context.Request.Method == "POST")
                {
                    StreamReader reader = new StreamReader(context.Request.Body);
                    string body = await reader.ReadToEndAsync();

                    Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);
                    if (queryDict.ContainsKey("firstName"))
                    {
                        string? name = queryDict["firstName"][0];
                        await context.Response.WriteAsync($"<p>Name: {name}<p>");
                    }
                }

                await context.Response.WriteAsync("<h1>Hello </h1>");
                await context.Response.WriteAsync("<h2>World!</h2>");
                await context.Response.WriteAsync($"<h2>{path}</h2>");

                await next(context);
            });

            // second middleware
            app.Use(async (HttpContext context, RequestDelegate next) => {
                await context.Response.WriteAsync("<h1>Hello Again</h1>");
                await next(context);
            });

            // third  middleware
            app.Run(async (HttpContext context) => {
                await context.Response.WriteAsync("<h1>Hello Again Again</h1>");
            });

            app.Run();
        }
    }
}
