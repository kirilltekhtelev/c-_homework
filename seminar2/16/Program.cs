Console.WriteLine("Enter first number");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if(Math.Pow(firstNumber, 2) == secondNumber || Math.Pow(secondNumber, 2) == firstNumber)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}