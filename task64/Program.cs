Console.WriteLine("Введите натуральное число больше 0:");
int N = int.Parse(Console.ReadLine());
 
void NumberCounter (int N)
{
    if (N == 0) return;
    Console.Write("{0,4}", N);
    NumberCounter (N - 1);
}
 
NumberCounter(N);