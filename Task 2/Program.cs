namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.PrintWelcome();

            int sum = calculator.Add(10, 10);
            Console.WriteLine("Additional Result: " + sum);

            int product1 = calculator.Multiply(5);
            Console.WriteLine("Multiplication Result with default value: " + product1);

            int product2 = calculator.Multiply(5, 3);
            Console.WriteLine("Multiplication Result with provided value: " + product2);


        }
    }
}