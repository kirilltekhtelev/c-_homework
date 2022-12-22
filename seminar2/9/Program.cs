int number = new Random().Next(10,100);

int firstDigitOfNumber = number / 10;
int secondDigitOfNumber = number %10;

Console.WriteLine(number);

if (firstDigitOfNumber > secondDigitOfNumber)
{
    Console.WriteLine($"max is: {firstDigitOfNumber}");
}
else
{
    Console.WriteLine($"max is: {secondDigitOfNumber}");
}