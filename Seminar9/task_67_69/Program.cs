Console.Clear();

int num1 = 4;
int num2 = 5;
int num3 = PowerOfTwoNumbers(num1, num2);
System.Console.WriteLine(num3);
int PowerOfTwoNumbers(int n1, int n2)
{
  if(n2 == 1) return n1;
  return n1 * PowerOfTwoNumbers(n1, n2 - 1);
}
System.Console.WriteLine();

int number = 15235897; 

int summDigitFromNum = SumDigitsFromNumber(number);
System.Console.WriteLine(summDigitFromNum);

int SumDigitsFromNumber(int num)
{
  if(num < 10) return num % 10;
  return num % 10 + SumDigitsFromNumber(num / 10);
}