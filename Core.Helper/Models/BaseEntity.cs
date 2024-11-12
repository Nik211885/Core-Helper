namespace Core.Helper.Models;

public abstract class BaseEntity<TKey>(TKey id)
{
    public TKey Id { get; } = id;
}