// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num;
System.Console.WriteLine($"Введи число ");
num= Convert.ToInt32(Console.ReadLine());;
int sum = 0;

while (num > 0)
{
    int a = num % 10;
    sum = sum + a;
    num = num / 10;
}
     System.Console.WriteLine($"Сумма цифр равна {sum} ");
if (num < 0)
System.Console.WriteLine("Некорректный ввод числа. Требуется положительное число");

