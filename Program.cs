string[] arrayOne = new string[4] { "1234", "1567", "-5", "Hollo" };
string[] arraySecond = new string[arrayOne.Length];

void SecondArrayEND(string[] arrayOne, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arraySecond[count] = arrayOne[i];
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
SecondArrayEND(arrayOne,arraySecond);
 PrintArray(arraySecond);

