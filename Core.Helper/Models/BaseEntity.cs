namespace Core.Helper.Models;

public abstract class BaseEntity<TKey>
{
    public TKey Id { get; set; }
}