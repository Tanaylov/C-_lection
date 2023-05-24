/* Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
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
*/

byte n1 = GetNumberFromUser("Enter first number (A): ");
byte n2 = GetNumberFromUser("Enter second number (B): ");
int summa = SummaFromAtoB(n1, n2);
Console.WriteLine("A = " + n1 + "; B = " + n2 + " -> " + summa);


byte GetNumberFromUser(string textEnter)
{
  byte num = 0;
  try
  {
    Console.Write(textEnter);
    num = byte.Parse(Console.ReadLine() ?? "");
  }
  catch(Exception excep){
    System.Console.WriteLine($"Enter wrong value of number. {excep.Message}");}
  return num;
}

int SummaFromAtoB(byte a, byte b)
{
  //byte index = a;
  while(a <= b) return a + SummaFromAtoB(Convert.ToByte(a + 1), b);
  return 0;
}