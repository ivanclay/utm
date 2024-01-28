namespace UtmBuilder.Core.Extensions;

public static class ListExtensions
{
    public static void addIfNotNull(
        this List<string> list,
        string key,
        string? value) 
    {
        if (!string.IsNullOrEmpty(value))
        {
            list.Add($"{key}={value}");
        }
    }
}
