using System.Globalization;

namespace Core.Helper.Helper;

public static class DateTimeHelper
{
    /// <summary>
    ///  Convert date time to string format is dd -- MM -- yyy format base date in viet nam
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="format"></param>
    /// <returns>
    ///     Return string for date time before convert date
    /// </returns>
    public static string ConvertDateToString(DateTimeOffset dateTime, string format = "dd-MM-yyyy")
        => dateTime.ToString(format);

    public static DateTimeOffset ConvertUtcToLocalTime(DateTimeOffset dateTimeUtc, string localTimeZoneId)
    {
        throw new Exception("Not implemented");
    }
}