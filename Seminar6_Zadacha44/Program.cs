/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int number = ReadInt("Введите число: ");
int[] fibonacci = new int[number];
fibonacci[0]=0;
fibonacci[1]=1;

for(int i = 2; i<number; i++)
{
    fibonacci[i] = fibonacci[i-1]+fibonacci[i-2];
}

Console.WriteLine($"Числа Фибоначчи до {number}: {String.Join(", ", fibonacci)}");

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}