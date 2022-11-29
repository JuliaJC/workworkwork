/*Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int [size];

FillArrayRandomNumbers(numbers,0,10);

Console.WriteLine("Введите искомое число: ");
int searchingNumber = Convert.ToInt32(Console.ReadLine());


WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if(searchingNumber == numbers[i])
    {
        Console.WriteLine("Такое число есть в массиве");
        return;
    }
}
Console.WriteLine("Такого числа в массиве нет");



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