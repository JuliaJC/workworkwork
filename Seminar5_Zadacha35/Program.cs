/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int size = 123;
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 1, 1000);
WriteArray(numbers);

int count = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]>10 && numbers[i]<99)
    {
        count += 1;
    }

}

Console.WriteLine(count);



void FillArrayRandomNumbers(int[] array, int min, int max)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max + 1);
}
}

void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

/*int[] MultipleArrayFirstAndLast(int[] array)
{
int size = array.Length;
for (int i = 0, g = size - 1; i < size / 2; i++, g--)
{
result[i] = numbers[i] * numbers[g];
}
return result;
}*/