// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
Console.Clear();
string userNumber = Console.ReadLine();
Console.WriteLine(userNumber);
int size = userNumber.Length;
Console.WriteLine(size);
int result = 0;

for (int index = 0; index < size; index++)
{
  //int indexNumber = int.Parse(userNumber[index]);
  char digit = Convert.ToInt32(userNumber[index]);

  result += digit;
  Console.WriteLine(digit);
}

Console.WriteLine(result);

/*
string numbers = "12345";
int[] intArray = new int[numbers.Length];
for (int i=0; i < numbers.Length; i++)
{
   intArray[i] = int.Parse(numbers[i]);
}
*/