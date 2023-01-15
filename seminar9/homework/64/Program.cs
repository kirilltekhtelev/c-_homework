int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int printNumber (int n)
{
    if (n == 0)
        return 1;
    else
    {
        Console.Write(n + " ");
        return printNumber(n-1);
    }
}

int n = readInt("Enter N:");

printNumber(n);