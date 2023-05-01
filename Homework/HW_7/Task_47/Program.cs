// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

byte rowNumber = GetDataFromUser("row count");
byte columnNumber = GetDataFromUser("column count");
float[,] twoDArray = Fill2DArray(rowNumber, columnNumber);
Print2DArray(twoDArray);

void Print2DArray(float[,] array)
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

float[,] Fill2DArray(byte row, byte column)
{
  float[,] array2D = new float[row, column];
  for(byte i = 0; i < row; i++)
  {
    for(byte j = 0; j < column; j++) 
      array2D[i, j] = (float)Math.Round(new Random().NextDouble() * (7 + 2) - 2, 2);
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

