Console.WriteLine("Enter first number:");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");

int secondnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number:");

int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(secondnumber > firstNumber || secondnumber > thirdNumber)
{
    max = thirdNumber;
    Console.WriteLine(max);
} 
else 
{
    if (thirdNumber > firstNumber)
    {
        max = thirdNumber;
        Console.WriteLine(max);
    }
    else
    {
        max = firstNumber;
        Console.WriteLine(max);
    }
}
