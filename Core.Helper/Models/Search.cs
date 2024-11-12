namespace Core.Helper.Models;
/// <summary>
///    model save field in query string all any information for search
/// </summary>
public class Search
{
    public List<Field> Fields { get;init; }
}

public class Field(string code, string value)
{
    public string Code { get;} = code;
    public string Value { get; } = value;
}