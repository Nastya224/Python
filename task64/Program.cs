//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


Console.WriteLine("Введите натуральное число больше 0:");
int N = int.Parse(Console.ReadLine());
 
void NumberCounter (int N)
{
    if (N == 0) return;
    Console.Write("{0,4}", N);
    NumberCounter (N - 1);
}
 
NumberCounter(N);