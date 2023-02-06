// массив из n = 1кк элементов
// найти максимульную сумму m = 10 последовательно идущих переменных
using System.Diagnostics;
int elements = 10;
int[] array = new int[elements];
int MAX = 0;
int MAX1 = 0; // для 2го варианта решения
System.Console.WriteLine("Введите количество последовательных элементов массива:");
int sequence = Convert.ToInt32(Console.ReadLine());
void FillArray(int[] inputArray)
{
    for (int l = 0; l < array.Length; l++)
    {
        array[l] = new Random().Next(1, 20);
    }
}
FillArray(array);
System.Console.WriteLine(String.Join(", ", array));
Stopwatch sw = new ();
sw.Start();
void FindMax (int [] inputArray, int inputSequence) // 1-й способ - в лоб (долго, т.к. 2 цикла)
{
int temp = 0;
for (int i = 0; i <= array.Length - sequence; i++)
{
    for (int j = i; j < i + inputSequence; j++)
    {
        temp = temp + array[j];
        if (MAX < temp) MAX = temp;
    }
    temp = 0;
}
}
sw.Stop();
FindMax(array, sequence);
System.Console.WriteLine($"Максимальное значение {sequence} последовательно идущих элементов: {MAX}");
System.Console.WriteLine($"Затраченное время на выполнение метода FindMax: {sw.ElapsedMilliseconds}");
sw.Reset();
sw.Start();
void FindMax2 (int [] inputArray, int inputSequence) // 2-й способ - быстрее
{
int temp1 = 0;
for (int j = 0; j < inputSequence; j++)
{
    temp1 += array[j];
}
MAX1 = temp1;
for (int i = 0; i < array.Length - inputSequence; i++)
{
    temp1 = temp1 - array[i] + array [i+inputSequence];
    if (temp1 > MAX1) MAX1 = temp1;
}
}
sw.Stop();
FindMax2(array, sequence);
System.Console.WriteLine($"Максимальное значение {sequence} последовательно идущих элементов: {MAX1}");
System.Console.WriteLine($"Затраченное время на выполнение метода FindMax2: {sw.ElapsedMilliseconds}");