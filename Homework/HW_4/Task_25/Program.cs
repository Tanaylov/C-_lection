// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)

Console.Clear();

double inputNumber_1 = 0;
double inputNumber_2 = 0; 
DegreeOfSecondNumber(ref inputNumber_1, ref inputNumber_2);

static void DegreeOfSecondNumber(ref double inputNumber_1, ref double inputNumber_2)
{
  while (true)
  {
    try
    {
      Console.WriteLine("Enter two number: ");
      inputNumber_1 = double.Parse(Console.ReadLine() ?? "".Replace('.', ','));
      inputNumber_2 = double.Parse(Console.ReadLine() ?? "".Replace('.', ','));
      double result = Math.Pow(inputNumber_1, inputNumber_2);
      Console.WriteLine(result);
    }
    catch (Exception exc)
    {
      Console.WriteLine($"Incorrect input! {exc.Message}");
      break;
    }
  }
}

