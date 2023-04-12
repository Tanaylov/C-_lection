Console.WriteLine("Hello, enter two integer: ");

double userNumber1 = double.Parse(Console.ReadLine() ?? "");
double userNumber2 = double.Parse(Console.ReadLine() ?? "");

if (userNumber1 * userNumber1 == userNumber2 || userNumber2 * userNumber2 == userNumber1)
{
  Console.WriteLine($"{userNumber1}, {userNumber2} -> Yes");
}
else
{
  Console.WriteLine($"{userNumber1}, {userNumber2} -> No");
}