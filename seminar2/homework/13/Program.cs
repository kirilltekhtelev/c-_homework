Console.WriteLine("Enter number");

int number = Convert.ToInt32(Console.ReadLine());

if(number / 100 % 10 != 0) {
    Console.WriteLine(number / 100 % 10 );
}
else
{
    Console.WriteLine("No third digit");
}