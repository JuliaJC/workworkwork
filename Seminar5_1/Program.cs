int size = 12;
int [] numbers = new int [size];
FillArrayRandomNumbers(numbers,-9,9);
WriteArray(numbers);

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        sumPositive += numbers[i];
    else
        sumNegative += numbers[i];
}

Console.WriteLine($"Сумма положительных равна {sumPositive}, Сумма отрицательных равна {sumNegative}");


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