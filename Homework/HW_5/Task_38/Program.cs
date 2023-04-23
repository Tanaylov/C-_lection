// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();

byte len = Convert.ToByte(new Random().Next(4, 11));
sbyte startNum = -10, finishNum = 10;


double [] array = GetArray(len, startNum, finishNum);
double diff = MaxMinusMin(array, len);
PrintResult (array, diff);


double [] GetArray(byte length, sbyte startNumer, sbyte finishNumer)
{
  double [] array = new double[length];
  for(byte i = 0; i < length;i++) 
  array[i] = Math.Round(new Random().NextDouble() * (finishNumer - startNumer) + startNumer, 3);
  return array; 
}

double MaxMinusMin(double [] array, byte length)
{
  double min = array[0], max = array[0];
  for(byte i = 0; i < length; i++)
  {
    if(min > array[i]) min = array[i];
    else if (max < array[i]) max = array[i];
  }
  double result = Math.Round(max - min, 3);
  return result;
}

void PrintResult(double [] array, double result)
{
  System.Console.WriteLine($"[{String.Join("; ", array)}] --- >>> {result}");
}








/*foreach(byte el in array)
  {
    min = el < el + 1 ? el : min;
    max = el > el + 1 ? el : max;
  }*/