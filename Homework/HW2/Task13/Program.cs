/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

//int userNumber = new Random().Next(1000000);

double userNumber;

while (true)
{
  Console.WriteLine("Please, enter a number: ");
  if (double.TryParse(Console.ReadLine(), out userNumber))
    break;
  Console.WriteLine("Incorrect enter number");
}

if (userNumber % 100 == userNumber)
{
  Console.WriteLine($"{userNumber} -> there is no third digit");
}
else
{
  int thirdDigit = int.Parse(Convert.ToString(userNumber)[2].ToString());
  Console.WriteLine($"{userNumber} -> {thirdDigit}");
}

//int a = int.Parse(Convert.ToString(x)[1].ToString());