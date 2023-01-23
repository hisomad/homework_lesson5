Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.WriteLine("]");
int result = 0;

for (int i = 0; i < array.Length; i+=2)
    result = result + array[i];

    Console.WriteLine($"Сумма элементов на нечётных позициях = {result}");

void FillArrayRandomNumbers(int[] array)
{
    Random rnd = new Random();
for(int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(1,10);
        
}

