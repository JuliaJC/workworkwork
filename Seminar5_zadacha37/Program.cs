/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 1, 10);
WriteArray(numbers);
int[] result = new int [size/2];
if(size % 2 == 0)
{
    for(int i = 0, lastIndex = size - 1; i < size/2; i++, lastIndex--) 
    {
        result[i] = numbers[i] * numbers[lastIndex];    
    }
}
else
{
    result = new int [size / 2 + 1];
    for(int i = 0, lastIndex = size - 1; i < size/2; i++, lastIndex--) 
    {
        result[i] = numbers[i] * numbers[lastIndex];
    }
    result[size/2]=numbers[size/2];
}
WriteArray(result);



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

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

/*void MultipleArrayFirstAndLast(int[] array, int[] pairs)
{
int size = array.Length;
for (int i = 0, g = size - 1; i < size / 2; i++, g--)
{
pairs[i] = array[i] * array[g];
}
}*/
