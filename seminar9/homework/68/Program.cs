int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int findAckerman (int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((n == 0) && (m > 0))
      return findAckerman(m - 1, 1);
    else
      return findAckerman(m - 1, findAckerman(m, n - 1));
}


int m = readInt("Enter M:");
int n = readInt("Enter N:");

int res = findAckerman(m, n);

Console.WriteLine(res);