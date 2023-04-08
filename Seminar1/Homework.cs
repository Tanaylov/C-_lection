//Task 2
/*Console.WriteLine("Enter two integers: ");

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
*/


//Task 4
/*Console.WriteLine("Enter three integers: ");

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
*/


//Task 6
/*Console.WriteLine("Enter an integer: ");

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
*/


//Task 8
/*
Console.WriteLine("Enter an integer: ");

//string userInput = Console.ReadLine() ?? "";

int userNumber = int.Parse(Console.ReadLine() ?? "");
int count = 2; 

while (count <= userNumber)
{
  if (count%2 == 0)
  {
    Console.Write($"{count}, ");
    count += 2;
  }
  else
  {
    count += 2;
  }
}
*/

string number = Console.ReadLine() ?? "";
Console.WriteLine($"{number} -> {number[^1]}");
