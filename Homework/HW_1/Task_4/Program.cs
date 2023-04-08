Console.WriteLine("Enter three integers: ");

string userInput_1 = Console.ReadLine() ?? "";
string userInput_2 = Console.ReadLine() ?? "";
string userInput_3 = Console.ReadLine() ?? "";

int userNumber_1 = int.Parse(userInput_1);
int userNumber_2 = int.Parse(userInput_2);
int userNumber_3 = int.Parse(userInput_3);

int max = userNumber_1;

if (userNumber_2 > max)
{
  max = userNumber_2;
}
if (userNumber_3 > max)
{
  max = userNumber_3;
}

Console.Write($"{userNumber_1}, {userNumber_2}, {userNumber_3}: -> {max}");
