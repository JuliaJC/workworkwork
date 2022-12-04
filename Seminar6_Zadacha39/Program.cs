/*Задача 39: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 1, 10);
WriteArray(numbers);

int[] revertNumber = new int [size];


for(int i = 0; i < revertNumber.Length; i++) 
{
    revertNumber[i] = numbers [numbers.Length - 1 - i];
}


WriteArray(revertNumber);

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

/*int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

for(int i = 0; i < numbers.Length / 2; i++)
{
int temp = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = numbers[i];
numbers[i] = temp;
}
WriteArray(numbers);

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
}*/