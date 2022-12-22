bool xNotEqualZero = false;
bool yNotEqualZero = false;
int x = 0;
int y = 0;

do
{
    Console.WriteLine("Enter x:");
    x = Convert.ToInt32(Console.ReadLine());
    if(x != 0)
    {
        xNotEqualZero = true;
    }
    else
    {
        Console.WriteLine("X must be ≠ 0");
    }
}
while(!xNotEqualZero);

do
{
    Console.WriteLine("Enter y:");
    y = Convert.ToInt32(Console.ReadLine());
    if(y != 0)
    {
        yNotEqualZero = true;
    }
    else
    {
        Console.WriteLine("Y must be ≠ 0");
    }
}
while(!yNotEqualZero);

Console.WriteLine($"x:{x}   y:{y}"); 

if(x >= 0)
{
    if (y >= 0)
    {
        Console.WriteLine("First queate"); 
    }
    else
    {
        Console.WriteLine("Fourth queate"); 
    }
}
else
{
    if (y >= 0)
    {
        Console.WriteLine("Second queate"); 
    }
    else
    {
        Console.WriteLine("Third queate"); 
    }
}