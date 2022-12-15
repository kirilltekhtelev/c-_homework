Console.WriteLine("Enter A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter B");
int b = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(b,2) == a) {
    Console.WriteLine("yes");
} else {
    Console.WriteLine("no");
}