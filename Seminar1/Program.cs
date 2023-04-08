Console.Write("Enter an integer: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
int result = userNumber * userNumber;
double rer = 8/3;
Console.Write($"{userInput}->{result}--{rer}");
//Console.Write("->");
//Console.Write(result);