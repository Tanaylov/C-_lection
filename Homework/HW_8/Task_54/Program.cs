/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2   */


Console.Clear();

byte subArrayQuantity = GetNumberFromUser(text: "Please enter the number to determine  sub-array quantity.",
                                          error: "You enter wrong number");
byte elementsQuantity = GetNumberFromUser(text: "Please enter the number to determine elements quantity.",
                                          error: "You enter wrong number");
short[,] array2D = Fill2DArray(subArrayQuantity, elementsQuantity);
Print2DArray(array2D);
System.Console.WriteLine("///////////////////////////////////");
OrderSubarraysDescendingly(array2D);

byte GetNumberFromUser(string text, string error)
{
  byte num;
  while(true)
  {
    Console.WriteLine(text);
    if(byte.TryParse(Console.ReadLine() ?? "", out num) && num > 0)
      break;
    Console.WriteLine(error);
  }
  return num;
}
short[,] Fill2DArray(byte subarray, byte elements)
{
  short[,] arr2D = new short[subarray, elements];
  short min, max;
  while(true)
    {
      min = (short)new Random().Next(0, short.MaxValue);
      max = (short)new Random().Next(0, short.MaxValue);
      if(min < max) break;
    }
  for(byte i = 0; i < subarray; i++)
    for(byte j = 0; j < elements; j++)
      arr2D[i, j] = (short)new Random().Next(min, max);
  return arr2D;
}
void Print2DArray(short[,] arr2D)
{
  for(byte i = 0; i < arr2D.GetLength(0); i++)
    {
      Console.Write("{");
      for(byte j = 0; j < arr2D.GetLength(1); j++)
        {
        if(j == arr2D.GetLength(1) - 1) Console.Write(arr2D[i, j]);
        else Console.Write(arr2D[i, j] + "||");      
        }
      Console.WriteLine("}");
    }
}
void OrderSubarraysDescendingly(short[,] arr2D)
{
  for(byte i = 0; i < arr2D.GetLength(0); i++)
  {
    for(byte j = 0; j < arr2D.GetLength(1); j++)
      {       
        for(byte k = 0; k < arr2D.GetLength(1) - 1; k++)
        {
          
          if(arr2D[i, k + 1] > arr2D[i, k])
          {
          short permanent = arr2D[i, k];
          arr2D[i, k] = arr2D [i, k + 1];
          arr2D [i, k + 1] = permanent;
          }
        } 
      }
  }
  Print2DArray(arr2D);
}
