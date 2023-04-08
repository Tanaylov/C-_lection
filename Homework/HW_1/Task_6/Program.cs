Console.WriteLine("Parity check");
Console.WriteLine("Enter an integer: ");

string userInput = Console.ReadLine() ?? "";

int userNumber = int.Parse(userInput);

if (userNumber%2 == 0)
{
  Console.Write($"{userNumber} -> YES");
}
else
{
  Console.Write($"{userNumber} -> NO");
}
