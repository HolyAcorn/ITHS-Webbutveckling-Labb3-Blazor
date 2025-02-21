namespace CvBlazorSite.Helpers;

public static class ProjectHelper
{
    private static string webImagePath = "/img/html.png";
    private static string blazorImagePath = "/img/blazor-logo.png";
    private static string appImagePath = "/img/C Sharp logo.svg";

    public static string GetImagePath(string type)
    {
        switch (type)
        {
            case "Web Development":
                return webImagePath;
            case "Blazor":
                return blazorImagePath;
            case "Application":
                return appImagePath;
            default:
                return "";
        }
    }
}