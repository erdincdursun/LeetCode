namespace FibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciIteratively(5);
        }
        public static int FibonacciIteratively(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            int result = 1;
            int lastNumber = 0;
            int temp;
            for (int i = 1; i < n; i++)
            {
                temp = result;
                result += lastNumber;
                lastNumber = temp;
            }
            return result;
        }
    }
}
