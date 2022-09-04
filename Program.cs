int SumDigits(int[] array)
{
int c = 0; int result = 0;
for (int j = 0; j < array.Length; j++)
{
    c = j % 2 != 0 ? array[j] : 0;
    result +=c;
}
    return result;
}
int[] list = new int[new Random().Next(4, 11)];
for (int i = 0; i < list.Length; i++)
{
    list[i] = new Random().Next(-100, 101);
    Console.Write(list[i] + " ");
}
Console.WriteLine(SumDigits(list));
