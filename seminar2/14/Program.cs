Console.WriteLine("Enter number");

int number = Convert.ToInt32(Console.ReadLine());


if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}