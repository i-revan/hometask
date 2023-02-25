namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1551;
            int digit1 = n % 10;
            int new_num = (n - digit1) / 10; //155
            int digit2 = new_num % 10; //5
            int new_num1 = (new_num - digit2) / 10; //15
            int digit3 = new_num1 % 10; //5
            int digit4 = (new_num1 - digit3) / 10;
            if(digit1 == digit4 && digit2 == digit3) {
                Console.WriteLine("YES");
                    }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}