namespace Average_of_max_and_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 30;
            int c = 10;
            int min = a;
            int max = a;
            if(b < min)
            {
                min = b;
            }
            if(c < min)
            {
                min = c;
            }
            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            Console.WriteLine((max + min) / 2);
        }
    }
}