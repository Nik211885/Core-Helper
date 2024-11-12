namespace Core.Helper.Helper;

public static class DateTimeHelper
{
    /// <summary>
    ///  Convert date time to string format is dd -- MM -- yyy format base date in viet nam
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns>
    ///     Return string for date time before convert date
    /// </returns>
    public static string ConvertDateToString(DateTimeOffset dateTime)
        => dateTime.ToString("dd-MM-yyyy");
}