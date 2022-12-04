/*Задача 45: Напишите программу, 
которая будет создавать копию заданного массива с помощью
поэлементного копирования.*/

int size = ReadInt("Введите размер массива: ");

int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 1, 10);
WriteArray(numbers);

int[] array = new int[size];

for(int i = 0; i < numbers.Length; i++)
{
    array[i] = numbers[i];
}

WriteArray(array);

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

/*
int size = ReadInt("Введите размер: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);

int[] copyNumbers = CopyArray(numbers);
WriteArray(numbers);
WriteArray(copyNumbers);

int[] CopyArray(int[] array)
{
int[] copyArray = new int[array.Length];
for(int i = 0; i < array.Length; i++)
{
copyArray[i] = array[i];
}
return copyArray;
}

void FillArrayRandomNumbers(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 10);
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
*/