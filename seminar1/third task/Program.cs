Console.Write("Enter number:");

int a = Convert.ToInt32(Console.ReadLine());

int i = 0;
int b = -(a*2);

while (i <= (a*2)) 
{
    Console.Write(b);
    i = i + 1;
    Console.Write(i);
    b = b + 1;
}