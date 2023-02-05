// массив из n = 1кк элементов
// найти максимульную сумму m = 10 последовательно идущих переменных
using System.Diagnostics;
int elements = 10;
int[] array = new int[elements];
int MAX = 0;
System.Console.WriteLine("Введите количество последовательных элементов массива:");
int sequence = Convert.ToInt32(Console.ReadLine());
void FillArray(int[] inputArray)
{
    for (int l = 0; l < array.Length; l++)
    {
        array[l] = new Random().Next(1, 20);
    }
}
Stopwatch sw = new ();
sw.Start();
void FindMax (int [] inputArray, int inputSequence)
{
int temp = 0;
for (int j = 0; j < inputSequence; j++)
{
    temp += array[j];
}
for (int i = 0; i < array.Length - inputSequence; i++)
{
    temp = temp - array[i] + array [i+inputSequence];
    if (temp > MAX) MAX = temp;
}
}
sw.Stop();
FillArray(array);
FindMax(array, sequence);
System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine($"Максимальное значение {sequence} последовательно идущих элементов: {MAX}");
System.Console.WriteLine($"Затраченное время на выполнение метода FindMax: {sw.ElapsedMilliseconds}");