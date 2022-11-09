string[] arrayGiven = new string[4] { "hello", "2", "world", ":-)" };
string[] arrayNew = new string[arrayGiven.Length];
void ArrayTransfer(string[] arrayGiven, string[] arrayNew)
{
    int n = 3;
    int j = 0;
    for (int i = 0; i < arrayGiven.Length; i++)
    {
        if (arrayGiven[i].Length <= n)
        {
            arrayNew[j] = arrayGiven[i];
            j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArrayTransfer(arrayGiven, arrayNew);
PrintArray(arrayNew);
