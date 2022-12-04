/*Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

int number = ReadInt("Введите десятичное число: ");

int temp = number;
string bynary = "";

while(temp != 0)
{
    bynary = temp%2 + bynary;
    temp /= 2;
}
Console.WriteLine(bynary);

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

/*Console.WriteLine("["+String.Join(" -> ", numbers)+ "] -> "+ sum);
Console.WriteLine($"[{String.Join(" -> ", numbers)}] -> {sum}");*/