int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int countDigitOfNumber (int number)
{
    int i = 0;
    do
    {
        if(number % 10 >= 0)
        {
            i += 1;
            number /= 10;
        }
    }
    while (number != 0);
    return i;
}

int number = readInt("Enter number");
int result = countDigitOfNumber(number);

Console.WriteLine(result);