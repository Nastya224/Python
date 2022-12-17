Console.WriteLine("Введите натуральное число больше нуля M:");
int M = int.Parse(Console.ReadLine());
 
Console.WriteLine("Введите натуральное число больше нуля N:");
int N = int.Parse(Console.ReadLine());
 
void GaPSum (int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++);
    GaPSum(M, N, sum);
}
 
GaPSum(M, N, 0);
