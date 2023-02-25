namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2560;
            int digit1 = n % 10; //5
            int new_num = (n - digit1) / 10; //238
            int digit2 = new_num % 10;
            int new_num1 = (new_num - digit2) / 10;
            int digit3 = new_num1 % 10;
            int digit4 = (new_num1 - digit3) / 10;
            Console.WriteLine(digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4);
        }
    }
}