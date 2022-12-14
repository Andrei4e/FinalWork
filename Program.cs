int AmountElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Count(); i++)
    {
        if (array[i].Length <= 3) count += 1;
    }
    return count;
}