namespace Core.Helper.Interface;

public interface IFactory<out TInstance>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    TInstance CreateInstance();
}