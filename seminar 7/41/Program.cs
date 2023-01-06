int readIn (string message)
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] createMassive (int m)
{
    int[] arr = new int[m];
    int i = 0;
    //string flag = "run";
    while(flag != "stop" || i < arr.Length)
    {
        arr[i] = readIn("Enter number");
        Console.WriteLine(arr[i]);
        i += 1;
    }
    return arr;
}

/*int countPositiveNumbersInArray (int[] arr)
{
    int s = 0;
    
}*/


int m = readIn("Enter m:");

int[] arr = createMassive(m);