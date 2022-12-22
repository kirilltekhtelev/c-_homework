Console.WriteLine("Enter coordinates A");

int aX = Convert.ToInt32(Console.ReadLine());
int aY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates B");

int bX = Convert.ToInt32(Console.ReadLine());
int bY = Convert.ToInt32(Console.ReadLine());

double distanceBetweenXY = Math.Sqrt(Math.Pow(bX-aX,2) + Math.Pow(bY-aY,2));


Console.WriteLine($"{distanceBetweenXY:f2}");