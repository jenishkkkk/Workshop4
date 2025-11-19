namespace Task_5
{
    internal class EnumAndRecord
    {
        public enum DayType
        {
            weekday,
            weekend
        }
        public record Book(string title, string author, double price);
    }
}