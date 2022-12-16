Console.WriteLine("Enter first number:");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");

int secondnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number:");

int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;


if(thirdNumber > firstNumber && thirdNumber > secondnumber) 
{
    max = thirdNumber;
}
else if (secondnumber > firstNumber)
{
    max = secondnumber;
}
else 
{
    max = firstNumber;
}

Console.WriteLine(max);