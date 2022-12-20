Console.WriteLine("Enter number");
int maxLineNumber = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i<=maxLineNumber)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i += 1;
}