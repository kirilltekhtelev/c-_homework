int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int factorialN (int n)
{
    if (n == 0)
        return 1;
    else
        return n * factorialN(n-1);
}

int n = readInt("Enter N");

int factorialOfNumber = factorialN(n);

Console.WriteLine(factorialOfNumber);