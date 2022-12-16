Console.Write("Enter number:");

int a = Convert.ToInt32(Console.ReadLine());

int i = 0;
int b = -a;

while (i <= (a*2)) 
{
    Console.Write(b+ " ");
    i = i + 1;
    b = b + 1;
}