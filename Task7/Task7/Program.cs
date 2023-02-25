namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 10;
            char operation = '/';
            switch (operation)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1-num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default: 
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}