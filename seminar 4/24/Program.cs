int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int sumFromOneToA (int a)
{
    int s = 0;
    for(int i = 1; i <= a; i++)
    {
        s+=i;
    }
    return s;
}

int a = readInt("Enter a number");

int result = sumFromOneToA(a);
Console.Write(result);
