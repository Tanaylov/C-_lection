// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

short[,] array2D = GetRandomArray();
Print2DArray(array2D);
ArithmeticAverageInColumn(array2D);

short[,] GetRandomArray()
{
  byte row = Convert.ToByte(new Random().Next(1, 7));
  byte column = Convert.ToByte(new Random().Next(1, 7));
  short[,] arr2D = new short[row, column];
  for(byte i = 0; i < row; i++)
  {
    for(byte j = 0; j < column; j++)
      arr2D[i, j] = Convert.ToInt16(new Random().Next(-15, 16));
  }
  return arr2D;
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

short[] ArrayFromColumn(byte row, byte i, short[,] array2D)
{
  short[] array = new short[row];
  for(byte j = 0; j < row; j++) array[j] = array2D[j, i];
  return array;
}

float AverrageOfNumber(short[] array)
{
  float result = 0;
  foreach(short elem in array)
    result += elem;
  result = (float) Math.Round(result / array.Length, 2);
  return result;
}

void ArithmeticAverageInColumn(short[,] arrayTwoDimension)
{
  byte countColumn = Convert.ToByte(arrayTwoDimension.GetLength(1));
  byte countRow = Convert.ToByte(arrayTwoDimension.GetLength(0));
  System.Console.WriteLine("Arithmetic average of each column:");
  for(byte i = 0; i < countColumn; i++)
  {
    short[] array = ArrayFromColumn (countRow, i, arrayTwoDimension);
    float result = AverrageOfNumber(array);
    System.Console.Write("|" + result);
  }
}
