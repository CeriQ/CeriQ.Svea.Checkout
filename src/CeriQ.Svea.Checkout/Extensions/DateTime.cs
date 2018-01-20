namespace System
{
    internal static class DateTimeExtensions
    {
        internal static string ToSveaString(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm");
        }
    }
}
