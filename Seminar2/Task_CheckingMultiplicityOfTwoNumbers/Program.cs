Console.Clear();

double userNumber;

while (true)
{
  Console.WriteLine("Please, enter a number: ");
  if (double.TryParse(Console.ReadLine(), out userNumber))
    break;
  Console.WriteLine("Incorrect enter first number");  
}

if (userNumber % 7 == 0 && userNumber % 23 == 0)
{
  Console.WriteLine("Yes");
}
else
{
  Console.WriteLine("No");
}