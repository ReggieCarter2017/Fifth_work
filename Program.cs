int Minus(int[] array)
{
    int temp = 0;
    for (int j = 0; j < array.Length; j++)
    {
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] > array[i+1])
        {
        temp = array[i];
        array[i] = array[i+1];
        array[i+1] = temp;
        }
    }
    }
    return array[^1] - array[0];
}

int[] list = new int[new Random().Next(10, 11)];
for (int i = 0; i < list.Length; i++)
{
    list[i] = new Random().Next(1, 100);
    Console.WriteLine("Изначальное число: " + list[i]);
}

Console.Write(Minus(list));