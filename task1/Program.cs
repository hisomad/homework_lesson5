Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
Console.Write("[");
Console.Write(string.Join(", ", numbers));
Console.WriteLine("]");

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
if (numbers[i] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел {count} четных");
