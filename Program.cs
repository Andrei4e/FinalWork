int AmountElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Count(); i++)
    {
        if (array[i].Length <= 3) count += 1;
    }
    return count;
}

string[] FillArray(string[] array, int count)
{
    int j = 0;
    string[] resultArray = new string[count];
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