// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// System.Console.WriteLine();

System.Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int st = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = num;
while (count < st)
{
    result = result * num;
    count++;
}
System.Console.WriteLine($"{result}");
