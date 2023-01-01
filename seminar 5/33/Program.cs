int readInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] createRandomMassive ()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
    return arr;
}

string findNumberInArray (int[] arr, int number)
{
    string answer = "no";
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == number)
        {
            answer = "yes";
            break;
        }
    }
    return answer;
}

int numberToFindInArray = readInt("Enter number");

int[] arr = createRandomMassive();

string answer = findNumberInArray(arr, numberToFindInArray);

Console.WriteLine(string.Join(",",arr));

Console.WriteLine(answer);