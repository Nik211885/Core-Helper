using Core.Helper.Common;

namespace Core.Helper.Models;
/// <summary>
///     username make foreign key and username is unique
/// </summary>
/// <param name="id"></param>
/// <param name="userName"></param>
/// <typeparam name="TKey"></typeparam>
public abstract class CoreEntity<TKey> : BaseEntity<TKey>
{
    public string CreatedBy { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string UpdatedBy { get; set; }
    public DateTimeOffset UpdatedAt{ get;  set; } 
}