// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
Console.Clear();

int userNumber = UserInput("Enter whole number: ", "Uncorrect number, try again, please.");
int result = DigitsSum(userNumber);
PrintFinalResalt(userNumber, result);

int UserInput(string enter, string error)
{
  while(true)
  {
    Console.WriteLine(enter);
    if(int.TryParse(Console.ReadLine() ?? "", out int number))
      return number;
    Console.WriteLine(error);
  }
}
int DigitsSum(int number)
{
  int sum = 0;
  int size = number.ToString().Length;
  for(int i = 0; i < size; i++)
  {
    sum += number%10;
    number /= 10;
  }
  return sum;
}
void PrintFinalResalt(int num, double result)
{
  Console.WriteLine($"{num} -> {result}");
}


