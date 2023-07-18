using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NpmForever;
using System.Net.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Using ClientFactory for better performance and following best practices.
builder.Services.AddHttpClient("npm", (client) =>
{
    client.BaseAddress = new Uri("http://registry.npmjs.org/");
});

var app = builder.Build();

// Minimal API by injecting ClientFactory.
app.MapGet("/info", async (string packageName,
    IHttpClientFactory factory) =>
    {
        var client = factory.CreateClient("npm");
        var response = await client.GetAsync($"{packageName}/latest/");

        // Checking if response was OK!
        if (!response.IsSuccessStatusCode)
        {
            return Results.BadRequest("error");
        }

        var info = response.Content.ReadFromJsonAsync<NpmInfo>();

        // Checking response format and making sure dependencies exists
        if (info.Result == null || info.Result?.dependencies == null)
        {
            return Results.BadRequest("error - not mathcing response");
        }

        return Results.Ok(info.Result?.dependencies);
    });


app.Run();
