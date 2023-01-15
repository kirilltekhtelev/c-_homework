int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int printNumber (int n, int m)
{
    if (n > m)
        return 0;
    else
        return n + printNumber(n + 1, m);
}

int n = readInt("Enter N:");
int m = readInt("Enter M:");

int sum = printNumber(n, m);

Console.WriteLine(sum);
