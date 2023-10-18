class Program
{
    static int powerMod(int a, int b, int mod)
    {
        int result = 1;
        while (b > 0)
        {
            if (b % 2 == 1)
                result = (result * a) % mod;
            a = (a * a) % mod;
            b /= 2;
        }
        return result;
    }

    static bool isPrime(int p)
    {
        Random rand = new Random();
        for (int i = 0; i < 20; i++)
        {
            int a = rand.Next(2, p - 1);
            if (powerMod(a, p - 1, p) != 1)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter the number to be checked:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isNumberPrime = isPrime(number);

        if (isNumberPrime)
            Console.WriteLine(number + " is a prime number.");
        else
            Console.WriteLine(number + " is not a prime number.");
    }
}