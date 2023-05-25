/* Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.Clear();

short number = (short)new Random().Next(-33, 34);
string intervalFromNto1 = NumberFromNto1(number);
Console.WriteLine($"N = {number} --> {intervalFromNto1}");

string NumberFromNto1(short num)
{
  if(num > 1) return $"{num}, {NumberFromNto1(Convert.ToInt16(num - 1))}";
//Следующую строчку сделал для практики, можно сказать.
//Знаю, что отрицательные числа не являются натуральными.
  else if(num < 1) return $"{num}, {NumberFromNto1(Convert.ToInt16(num + 1))}"; 
  else return $"{num}";
}
