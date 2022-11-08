string[] array1 = new string[4] { "hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];
void Array2Check(string[] array1, string[] array2)
{
    int n = 3;
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= n)
        {
            array2[j] = array1[i];
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

Array2Check(array1, array2);
PrintArray(array2);
