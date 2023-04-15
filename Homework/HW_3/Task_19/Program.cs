Console.Clear();

int userNumber;

while (true)
{
  Console.WriteLine("Enter 5-digits number: ");

  if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber.ToString().Length == 5)
    break;
  Console.WriteLine("What you entered is not a number or not 5-digits number, please, try again");
}

int digit_1 = userNumber / 10000;
int digit_2 = userNumber / 1000 % 10;
int digit_4 = userNumber % 100 / 10;
int digit_5 = userNumber % 10;

if (digit_1 != digit_5 || digit_2 != digit_4)
{
  Console.WriteLine(userNumber + "-> No");
}
else 
{
  Console.WriteLine(userNumber + "-> Yes");
}
