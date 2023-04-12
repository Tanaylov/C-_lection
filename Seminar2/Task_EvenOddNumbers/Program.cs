Console.WriteLine("Enter two numbers: ");


double userNumber1 = double.Parse(Console.ReadLine() ?? "");
double userNumber2 = double.Parse(Console.ReadLine() ?? "");
double remainder = userNumber1 % userNumber2;

if (userNumber1 % userNumber2 != 0)
{
  Console.WriteLine($"{userNumber1}, {userNumber2} -> не кратно, остаток {remainder}");
}
else if (userNumber1 % userNumber2 == 0)
{
  Console.WriteLine($"{userNumber1}, {userNumber2} -> кратно");
}