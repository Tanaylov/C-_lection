/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();

double numberOfDay;

while (true)
{
  Console.WriteLine("Enter the number that matches the day of the week: ");
  if(double.TryParse(Console.ReadLine(), out numberOfDay))
  break;
  Console.WriteLine("was not a number entered");
}

if (numberOfDay > 0 && numberOfDay < 6)
{
  Console.WriteLine($"{numberOfDay} -> No");
}
else if (numberOfDay == 6 || numberOfDay == 7)
{
  Console.WriteLine($"{numberOfDay} -> Yes");
}
else
{
  Console.WriteLine($"The number isn't matches the day of the week.");
}