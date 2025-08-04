namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1234;

            Console.WriteLine(sumOfDigits(number));
        }
        static int sumOfDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                // Get the next integer or digit in the number
                int numberElement = number % 10;

                // Remove that integer or digit from number and add it to the sum
                number /= 10;

                sum += numberElement;
            }
            return sum;
        }
    }
}
