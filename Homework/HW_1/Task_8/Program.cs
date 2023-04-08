Console.WriteLine("Enter an integer: ");

//string userInput = Console.ReadLine() ?? "";

int userNumber = int.Parse(Console.ReadLine() ?? "");
int count = 2; 

while (count <= userNumber)
{
  if (count%2 == 0)
  {
    Console.Write($"{count} ");
    count += 2;
  }
  else
  {
    count += 2;
  }
}
