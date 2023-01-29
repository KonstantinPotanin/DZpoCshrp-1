// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

void LangeNumber (int num1, int num2)
{
    if (num1 == num2)
    Console.WriteLine ("Числа равны");
    else if (num1 > num2)
    Console.WriteLine ("Первое число больше второго");
    else Console.WriteLine("Первое число меньше второго");
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());
LangeNumber (num1, num2);
