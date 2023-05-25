/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Clear();

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
  if(a < b) while(a <= b) return a + SummaFromAtoB(Convert.ToByte(a + 1), b);
  if(a > b) while(a >= b) return a + SummaFromAtoB(Convert.ToByte(a - 1), b);
  return a;
}
