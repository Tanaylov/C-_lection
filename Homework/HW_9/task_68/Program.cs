/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.Clear();

double num1 = (double)new Random().Next(0, 3);
double num2 = (double)new Random().Next(25, 100);
double numAkkerman = AkkermanFunction(num1, num2);
Result(numAkkerman, num1, num2);

void Result(double num, double value1, double value2)
{
  Console.WriteLine($"m = {value1}, n = {value2} -> A({value1}, {value2}) = {num}");
}
double AkkermanFunction(double m, double n)
{
  if (m == 0)
    return n + 1;
  else
    if (m > 0 && n == 0)
      return AkkermanFunction(m - 1, 1);
    else
      return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}