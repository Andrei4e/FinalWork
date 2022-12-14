int AmountElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Count(); i++)
    {
        if (array[i].Length <= 3) count += 1;
    }
    return count;
}

string[] FillResultArray(string[] array, int sizeArray)
{
    int j = 0;
    string[] resultArray = new string[sizeArray];
    for (int i = 0; i < array.Count(); i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j += 1;
        }
    }
    return resultArray;
}

string[] FillArray(int sizeArray)
{
    string[] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.Write($"Введите строку {i + 1} массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Count(); i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

Console.Write("Введите количество строк добавляемых в массив: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int sizeResultArray = 0;

string[] array = new string[sizeArray];
array = FillArray(sizeArray);
sizeResultArray = AmountElements(array);

if (sizeResultArray == 0) Console.Write("В исходном массиве нет строк длинной 3 или меньше символов");
else
{
    Console.WriteLine("В нашем массиве содержатся следующие строки, которые содержат 3 или меньше символов");
    PrintArray(FillResultArray(array, sizeResultArray));
}