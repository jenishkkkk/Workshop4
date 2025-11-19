namespace Task_3
{
    internal class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number = number + 10;
        }
        public void GetFullName(out string fullname)
        {

            fullname = "Jenish kunwar";
        }
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum = sum + n;
            }
            return sum;
        }
    }
}