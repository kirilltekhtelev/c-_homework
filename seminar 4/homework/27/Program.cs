int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int countSumOfDigitOfNumber (int number)
{
    int s = 0;
    do
    {
        if(number % 10 >= 0)
        {
            s += number % 10;
            number /= 10;
        }
    }
    while (number != 0);
    return s;
}

int number = readInt("Enter number");
int result = countSumOfDigitOfNumber(number);

Console.WriteLine(result);