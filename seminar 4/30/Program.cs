int[] arrayOfOneOrZero = new int[8];
for (int i = 0; i < arrayOfOneOrZero.Length; i++)
{
arrayOfOneOrZero[i] = new Random().Next(0,2);
}

Console.WriteLine(string.Join(", ", arrayOfOneOrZero));
