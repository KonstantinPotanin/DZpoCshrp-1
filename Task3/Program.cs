// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

void EvenNumber (int num)
{
    if (num % 2 == 0)
    Console.WriteLine ("Число четное");
    
    else Console.WriteLine("Число нечетное");
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
EvenNumber (number);
