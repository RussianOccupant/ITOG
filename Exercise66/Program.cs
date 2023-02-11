// Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

void Main()
{
    Console.Write("Enter number M: ");
    int M = int.Parse(Console.ReadLine()!);
    Console.Write("Enter number N: ");
    int N = int.Parse(Console.ReadLine()!);
    Console.WriteLine(PrintSumNumbers(M, N));
}
Main();
int PrintSumNumbers(int M, int N)
{
    if (M == N) return M;
    else
        return M + PrintSumNumbers(M + 1, N);
}