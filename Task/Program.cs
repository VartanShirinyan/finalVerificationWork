string[] firstArray = new string[5] { "1", "final", "task", "in", "GeekBrains" };
string[] secondArray = new string[firstArray.Length];
void SecondArrayWithIF(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
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
SecondArrayWithIF(firstArray, secondArray);
Console.WriteLine("Вывод оригинального массива");
PrintArray(firstArray);
Console.WriteLine("Вывод нового массива");
PrintArray(secondArray);