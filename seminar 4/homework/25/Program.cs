int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int powAToDegreeB (int a, int b)
{
    if (b == 0)
        return 1;
    else 
        return a * powAToDegreeB(a, b-1);
}

int a = readInt("Enter A");
int b = readInt("enter B");

int result = powAToDegreeB(a, b);

Console.WriteLine(result);