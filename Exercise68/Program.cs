// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа М и N/
// m = 2, n = 3 => A(m, n) = 9

static uint Akkerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine(Akkerman(2, 4));