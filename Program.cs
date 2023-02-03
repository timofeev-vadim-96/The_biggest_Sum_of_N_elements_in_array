// массив из n = 1кк элементов
// найти максимульную сумму m = 10 последовательно идущих переменных
int elements = 20;
int[] array = new int[elements];
int MAX = 0;
int step = 0;
System.Console.WriteLine("Введите количество последовательных элементов массива:");
int sequence = Convert.ToInt32(Console.ReadLine());
void FillArray(int[] inputArray)
{
    for (int l = 0; l < array.Length; l++)
    {
        array[l] = new Random().Next(1, 20);
    }
}
void FindMax (int [] inputArray, int inputSequence)
{
int temp = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0 + step; j < step + inputSequence; j++)
    {
        if ((step + inputSequence) > array.Length) break;
        temp = temp + array[j];
        if (MAX < temp) MAX = temp;
    }
    temp = 0;
    step++;
}
}
void PrintArray(int [] inputArray)
{
    for (int k = 0; k < array.Length; k++)
    {
        System.Console.Write($"{array[k]} ");
    }
}
FillArray(array);
FindMax(array, 3);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальное значение {sequence} последовательно идущих элементов: {MAX}");