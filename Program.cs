string[] arrayFirst = new string[8] { "opa", "go", "C#", "dotnet", "155", "sdfjwsoig", "afd", "qw" };
string[] arraySecond = new string[arrayFirst.Length];
void SecondArray(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i].Length <= 3)
        {
            arraySecond[count] = arrayFirst[i];
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

SecondArray(arrayFirst, arraySecond);
PrintArray(arrayFirst);
PrintArray(arraySecond);
