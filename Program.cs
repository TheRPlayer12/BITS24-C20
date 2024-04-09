class Program
{
    static List<int> Calculate(int n)
    {
        List<int> powersOf2 = [];
        int power = 0;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                powersOf2.Add((int)Math.Pow(2, power));
            }
            n = n/2;
            power++;
        }
        return powersOf2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());

        List<int> ans = Calculate(input);
        Console.WriteLine(string.Join(" ", ans));
    }
}