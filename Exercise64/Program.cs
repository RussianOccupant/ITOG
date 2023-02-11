// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.


string PrintNumbers(int n)
{
    if (n == 1) return "1";
    else 
    {
        return $"{n} " + PrintNumbers(n - 1);
    }
}

Console.WriteLine(PrintNumbers(8));