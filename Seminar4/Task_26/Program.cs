// 489 -> 3; 78945 -> 5
Console.Clear();

int userNumber = InputFromUser("Enter whole number/integer: ", "You entering not a number or not correct number");
int count = DigitCount(userNumber);
OutputResult(userNumber, count);

int InputFromUser(string messegeForUser, string errorMessage)
{
  while (true)
  {
    Console.WriteLine(messegeForUser);
    if (int.TryParse(Console.ReadLine(), out int userNumber))
    return userNumber;
    Console.WriteLine(errorMessage);
  }
} 
int DigitCount(int num)
{
  string numberFromUser = num.ToString();
  int result = 0;
  int index = numberFromUser.Length;
  while(index > 0)
  {
    result += 1;
    index--;
  }
  return result;
}
void OutputResult(int InputNumber, int digitsCount)
{
  Console.WriteLine($"{InputNumber} -> {digitsCount}");
}
