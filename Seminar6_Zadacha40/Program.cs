/*Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.*/

int number1 = ReadInt("Введите число 1: ");
int number2 = ReadInt("Введите число 2: ");
int number3 = ReadInt("Введите число 3: ");

if (number1<number2+number3 && number2<number1+number3 && number3<number1+number2) 
{
    Console.Write("Такой треугольник может существовать");
}
else
{
    Console.Write("Такой треугольник не может существовать");
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

/*
int lineA = ReadInt("Введите сторону A: ");
int lineB = ReadInt("Введите сторону B: ");
int lineC = ReadInt("Введите сторону C: ");

if(CheckSide(lineA, lineB, lineC) && CheckSide(lineB, lineA, lineC) && CheckSide(lineC, lineB, lineA))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

bool CheckSide(int checkSide, int a , int b)
{
return checkSide < a + b;
}
*/