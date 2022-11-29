/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int [size];
FillArrayRandomNumbers(numbers,-9,9);
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
}

WriteArray(numbers);


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