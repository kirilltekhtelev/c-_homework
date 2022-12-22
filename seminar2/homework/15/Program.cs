Console.WriteLine("Enter day of the week as a number");

int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek >= 6 && dayOfWeek <= 7)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}