Console.WriteLine("Enter first number");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    Console.Write("Max = {0}, ",firstNumber);
    Console.Write("Min = {0}, ",secondNumber);
} else 
{
    Console.Write("Min = {0}, ",firstNumber);
    Console.Write("Max = {0}, ",secondNumber);
}
