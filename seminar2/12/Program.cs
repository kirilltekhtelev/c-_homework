Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int remaiderOfDivision = 0;

if (firstNumber % secondnumber == 0)
{
    Console.WriteLine("Multiple");
}
else
{
    remaiderOfDivision = firstNumber % secondnumber;
    Console.WriteLine($"Not multiple, remainder of the division: {remaiderOfDivision}");
}