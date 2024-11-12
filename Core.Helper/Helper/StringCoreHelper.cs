namespace Core.Helper.Helper;

public static class StringCoreHelper
{
    public static string GetStringFromDateNow()
        => DateTimeOffset.UtcNow.ToString("yyyyMMddHHmmss");
    public static Guid GetGuidKeyId() => Guid.NewGuid();
    public static string MakeKeyId(params string[] code) 
        => string.Concat(string.Join("_",code),"_",GetStringFromDateNow());
}