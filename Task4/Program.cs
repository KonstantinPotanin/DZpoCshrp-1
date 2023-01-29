// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

void AllNumberN (int num)
{
    int current = 2;
    while (current <= num)
    {
        Console.Write (current + " ");
        current += 2;
    }

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
AllNumberN (number);