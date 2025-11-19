namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterDemo demo = new ParameterDemo();

            int value = 5;
            demo.Increase(ref value);
            Console.WriteLine($"Increased Value: {value}");

            demo.GetFullName(out string myName);
            Console.WriteLine($"Full Name: {myName}");

            int sum = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}