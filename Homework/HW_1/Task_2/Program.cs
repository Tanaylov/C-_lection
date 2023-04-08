Console.WriteLine("Enter two integers: ");

string userInput_1 = Console.ReadLine() ?? "";
string userInput_2 = Console.ReadLine() ?? "";

int userNumber_1 = int.Parse(userInput_1);
int userNumber_2 = int.Parse(userInput_2);

int max = userNumber_1;

if (max > userNumber_2)
{
  Console.Write($"max = {max}");
}
else
  Console.Write($"max = {userNumber_2}");
