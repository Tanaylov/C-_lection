Console.WriteLine("Enter two numbers: ");

/*
double userNumber1 = double.Parse(Console.ReadLine() ?? "");
double userNumber2 = double.Parse(Console.ReadLine() ?? "");
*/

double userNumber1; 
double userNumber2;

while (true)
{
  //Console.Write("Enter two numbers: ");
  if (double.TryParse(Console.ReadLine(), out userNumber1))
    break;
  Console.WriteLine("Incorrect enter first number");  
}

while (true)
{
  //Console.Write("Enter two numbers: ");
  if (double.TryParse(Console.ReadLine(), out userNumber2))
    break;
  Console.WriteLine("Incorrect enter second number");
}

double remainder = userNumber1 % userNumber2;

if (remainder != 0)
{
  Console.WriteLine($"{userNumber1}, {userNumber2} -> не кратно, остаток {remainder}");
}
else 
{
  Console.WriteLine($"{userNumber1}, {userNumber2} -> кратно");
}
