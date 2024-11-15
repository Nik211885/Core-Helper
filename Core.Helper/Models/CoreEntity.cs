using Core.Helper.Common;

namespace Core.Helper.Models;
/// <summary>
///     username make foreign key and username is unique
/// </summary>
/// <param name="id"></param>
/// <param name="userName"></param>
/// <typeparam name="TKey"></typeparam>
public abstract class CoreEntity<TKey>
    (TKey id, string? userName) : BaseEntity<TKey>(id)
{
    public string CreatedBy { get; } = userName ?? ConstVariable.DEFAULT_USER_NAME;
    public DateTimeOffset CreatedAt { get; } = DateTimeOffset.UtcNow;
    public string UpdatedBy { get; private set; } = userName ?? ConstVariable.DEFAULT_USER_NAME; 
    public DateTimeOffset UpdatedAt{ get; private set; } = DateTimeOffset.UtcNow;

    public void UpdateCoreEntity(string? updatedBy)
    {
        UpdatedBy = updatedBy ?? ConstVariable.DEFAULT_USER_NAME;
        UpdatedAt = DateTimeOffset.UtcNow;
    }
}