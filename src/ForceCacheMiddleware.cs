namespace ServiceWorkerCacheBuster;

public class ForceCacheMiddleware
{
    private readonly RequestDelegate _next;

    public ForceCacheMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Response.Headers.CacheControl = "public, max-age=31536000";

        await _next(context);
    }
}