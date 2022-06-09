using ServiceWorkerCacheBuster;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<ForceCacheMiddleware>();

var staticFiles = new StaticFiles();

app.MapGet("/resource", () =>
{
    var fileStream = true // some condition set at runtime that controls which resource version we serve
        ? staticFiles.GetResourceV1()
        : staticFiles.GetResourceV2();

    return Results.Stream(fileStream, "text/html"); ;
});

app.MapGet("/", () =>
{
    var fileStream = staticFiles.GetLogin();
    return Results.Stream(fileStream, "text/html");
});

app.Run();
