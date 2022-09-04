int[] array = new int[new Random().Next(10, 11)]; int count = 0; int b = 0;
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);
for (int j = 0; j < array.Length; j++) count = array[j] % 2 == 0 ? b++ : 0;
Console.Write(b);

