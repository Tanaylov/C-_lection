Console.Clear();

int userNumber;

while (true)
{
  Console.WriteLine("Please, enter a three-digit number: ");
  if (int.TryParse(Console.ReadLine(), out userNumber))
    break;
  Console.WriteLine("Incorrect enter a number");  
}

int digit2 = userNumber / 10 % 10;
string userNumberS = userNumber.ToString();
int len = userNumberS.Length;

if (len == 3)
{
  Console.WriteLine($"{userNumber} -> {digit2}");
}
else
{
  Console.WriteLine("Need enter 3-digit number");
}
