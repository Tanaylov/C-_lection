/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
Console.Clear();

byte numSubArr = GetQuantity(text:"Enter the sub-arrays quantity: ",
                             error:"You entered wrong number, try again.");
byte numElemen = GetQuantity(text:"Enter the elements quantity: ",
                             error:"You entered wrong number, try again.");

sbyte maxValue, minValue;
while(true)
{
  maxValue = GetRangeNumbers(text1:"Enter maximum value in sub-array: ",
                                 error1:"You entered wrong number, try again.");
  minValue = GetRangeNumbers(text1:"Enter minimum value in sub-array: ",
                                 error1:"You entered wrong number, try again.");
  if(maxValue > minValue) break;
  Console.WriteLine("Minimum value is greater than maximum value.");
}

sbyte[,] our2DArray = Get2DArrayFromUser(numSubArr, numElemen, maxValue, minValue);
sbyte[,] random2DArray = GetRandom2DArray(numElemen);
int[,] array2DResult = MultiplicationOf2DArray(our2DArray, random2DArray);
Console.WriteLine("------------First 2D array----------");
Print2DArray(our2DArray);
Console.WriteLine("------------Second 2D array--------");
Print2DArray(random2DArray);
Console.WriteLine("---------2D array multiplication----------");
Print2DArrayInt(array2DResult);

byte GetQuantity(string text, string error)
{
  while(true)
  {
    Console.WriteLine(text);
    if(byte.TryParse(Console.ReadLine() ?? "", out byte num) && num != 0) return num;
    Console.WriteLine(error);
  }
}
sbyte GetRangeNumbers(string text1, string error1)
{
  while(true)
  {
    Console.WriteLine(text1);
    if(sbyte.TryParse(Console.ReadLine() ?? "", out sbyte num1)) return num1;
    Console.WriteLine(error1);
  }
}

sbyte[,] Get2DArrayFromUser(byte numOfSubArray, byte numElements, sbyte maxV, sbyte minV)
{
  sbyte[,] arr2D = new sbyte[numOfSubArray, numElements];
  for(byte i = 0; i < numOfSubArray; i++)
    for(byte j = 0; j < numElements; j++)
      arr2D[i, j] = (sbyte)new Random().Next(minV, maxV + 1);
  return arr2D;
}

sbyte[,] GetRandom2DArray(byte numOfEl)
{
  byte numOfSubArray;
  while(true)
  {
    numOfSubArray = (byte)new Random().Next(1, 11);
    if(numOfEl == numOfSubArray) break;
  }
  byte numOfElements = (byte)new Random().Next(1, 11);
  
  sbyte[,] arr2D = new sbyte[numOfSubArray, numOfElements];
  for(byte i = 0; i < numOfSubArray; i++)
    for(byte j = 0; j < numOfElements; j++)
      arr2D[i, j] = (sbyte)new Random().Next(sbyte.MinValue, sbyte.MaxValue + 1); 
  return arr2D;
}

void Print2DArray(sbyte[,] arr)
{
  for(byte i = 0; i < arr.GetLength(0); i++)
  {
    for(byte j = 0; j < arr.GetLength(1); j++)
      Console.Write(arr[i, j] + "|");
  Console.WriteLine();
  }
}

void Print2DArrayInt(int[,] arr)
{
  for(byte i = 0; i < arr.GetLength(0); i++)
  {
    for(byte j = 0; j < arr.GetLength(1); j++)
      Console.Write(arr[i, j] + "|");
  Console.WriteLine();
  }
}

int[,] MultiplicationOf2DArray(sbyte[,] arr1, sbyte[,] arr2)
{
  int[,] resultArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
  for(byte i = 0; i < arr1.GetLength(0); i++)
    for(byte j = 0; j < arr2.GetLength(1); j++)
      for(byte k = 0; k < arr1.GetLength(1); k++)
        resultArray[i, j] += arr1[i, k] * arr2[k, j];
  return resultArray;
}

