namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 587;
            int digit1 = n % 10;
            int new_num = (n - digit1) / 10;
            int digit2 = new_num % 10;
            int digit3 = (new_num - digit2) / 10;
            int sum_of_digits = digit1 + digit2 + digit3;
            Console.WriteLine(sum_of_digits);
        }
    }
}