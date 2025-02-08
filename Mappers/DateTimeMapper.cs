using System.Globalization;

namespace Risk.Mappers
{
    public static class DateTimeMapper
    {
        public static DateTime ConvertToDateTime(this string dateTime) =>
            DateTime.ParseExact(dateTime, "MM/dd/yyyy", CultureInfo.InvariantCulture);
    }
}
