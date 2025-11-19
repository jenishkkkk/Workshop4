using static Task_5.EnumAndRecord;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello user! Enter a day: ");
            string input = Console.ReadLine().ToLower();

            if (input == "friday" || input == "saturday")
            {
                Console.WriteLine($"The day {input} is a {EnumAndRecord.DayType.weekend}.");
            }
            else
            {
                Console.WriteLine($"The day {input} is a {EnumAndRecord.DayType.weekday}.");
            }

            EnumAndRecord.Book book1 = new EnumAndRecord.Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
            Book book2 = book1 with { title = "Advanced C#", price = 49.99 };

            Console.WriteLine($"\nBook 1: {book1.title}, Author: {book1.author}, Price: ${book1.price}");

            var (title, author, price) = book2;
            Console.WriteLine("\nDeconstructed Second Book:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }

    }
}