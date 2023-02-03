// массив из n = 1кк элементов
// найти максимульную сумму m = 10 последовательно идущих переменных
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
void FindMax (int [] inputArray, int inputSequence)
{
int temp = 0;
for (int i = 0; i < array.Length - sequence; i++)
{
    for (int j = i; j < i + inputSequence; j++)
    {
        temp = temp + array[j];
        if (MAX < temp) MAX = temp;
    }
    temp = 0;
}
}

FillArray(array);
FindMax(array, 3);
System.Console.WriteLine(String.Join(", ", array));

System.Console.WriteLine($"Максимальное значение {sequence} последовательно идущих элементов: {MAX}");