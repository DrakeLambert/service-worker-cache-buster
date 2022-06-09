namespace ServiceWorkerCacheBuster;

public class StaticFiles
{
    private const string STATIC_FILE_ROOT = "wwwroot";
    private readonly string LOGIN_FILE_PATH = Path.Join(STATIC_FILE_ROOT, "login.html");
    private readonly string RESOURCE_V1_FILE_PATH = Path.Join(STATIC_FILE_ROOT, "resource-v1.html");
    private readonly string RESOURCE_V2_FILE_PATH = Path.Join(STATIC_FILE_ROOT, "resource-v2.html");

    public Stream GetLogin() => File.OpenRead(LOGIN_FILE_PATH);

    public Stream GetResourceV1() => File.OpenRead(RESOURCE_V1_FILE_PATH);

    public Stream GetResourceV2() => File.OpenRead(RESOURCE_V2_FILE_PATH);
}