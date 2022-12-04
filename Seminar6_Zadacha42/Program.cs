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
    bynary += Convert.ToString(temp%2);
    temp /= 2;
}
string result = "";
for(int i = bynary.Length-1; i >=0; i--) 
{
    result += bynary [i];
}


Console.WriteLine(bynary);
Console.WriteLine(result);

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

/*Console.WriteLine("["+String.Join(" -> ", numbers)+ "] -> "+ sum);
Console.WriteLine($"[{String.Join(" -> ", numbers)}] -> {sum}");*/