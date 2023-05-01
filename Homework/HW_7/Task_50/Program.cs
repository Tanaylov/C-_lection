// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

byte rowNumber = GetDataFromUser("row count");
byte columnNumber = GetDataFromUser("column count");
short checkingNumber = GetDataFromUser("number to check");

short[,] twoDArray = Fill2DArray(rowNumber, columnNumber);
Print2DArray(twoDArray);

//CheckForNumber(twoDArray, checkingNumber);
short number = CheckForNumber(twoDArray, checkingNumber);
Solution(number, checkingNumber);

void Solution(short num, short numUser)
{
  if(numUser == 0 && num != 1)
    System.Console.WriteLine($"Number {numUser} is in array");
  else if(numUser == 0 && num == 1)
    System.Console.WriteLine($"Number {numUser} is not in array");
  else if(numUser != 0 && numUser == num)
    System.Console.WriteLine($"Number {numUser} is in array");
  else
    System.Console.WriteLine($"Number {numUser} is not in array");
}

void Print2DArray(short[,] array)
{
  for(byte i = 0; i < array.GetLength(0); i++)
  {
    System.Console.Write("{ ");
    for(byte j = 0; j < array.GetLength(1); j++)
      if(j < array.GetLength(1) - 1)
        System.Console.Write(array[i, j] + " | ");
      else
        System.Console.Write(array[i, j]);
    System.Console.WriteLine(" }");
  }
}

short[,] Fill2DArray(byte row, byte column)
{
  short[,] array2D = new short[row, column];
  for(byte i = 0; i < row; i++)
  {
    for(byte j = 0; j < column; j++) 
      array2D[i, j] = Convert.ToInt16(new Random().Next(-11, 19));
  }
  return array2D;
}

byte GetDataFromUser(string text)
{
  byte num;
  while(true)
  {
    Console.WriteLine($"Enter {text}");
    if(byte.TryParse(Console.ReadLine(), out num))
      break;
    Console.WriteLine("Wrong number."); 
  } 
  return num;
}

short CheckForNumber(short[,] array, short number)
{
  short num;
  if(number == 0) // для проверки значения элемента равного 0.
    num = 1;
  else
    num = 0;
  foreach(short el in array)
  {
    if(el == number) num = el;  
  } 
  return num;
}

/*
void CheckForNumber (short[,] array, short number)
{
  byte count = 0;
  foreach(short el in array)
  {
    if(el == number) count++;
  } 
  if(count > 0) System.Console.WriteLine("Yes"); 
  else System.Console.WriteLine("No");
}
*/

