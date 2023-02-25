string[] Array = new string[5] { "1", "final", "task", "in", "GeekBrains" };
string[] newArray = new string[Array.Length];
void newArrayWithIF(string[] Array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            newArray[count] = Array[i];
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
newArrayWithIF(Array, newArray);
Console.WriteLine("Output of the original array");
PrintArray(Array);
Console.WriteLine("Output of a new array");
PrintArray(newArray);