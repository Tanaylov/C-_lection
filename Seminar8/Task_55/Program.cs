Console.Clear();

Random r = new Random();
byte subArr = (byte)r.Next(3, 7);
byte elementsNum = (byte)r.Next(3, 7);
byte minValue = (byte)r.Next(1, 30);
byte maxValue = (byte)r.Next(31, 100);

byte[,] array2D = Fill2DemArray(subArr, elementsNum, minValue, maxValue); 
Print2DArray(array2D, subArr, elementsNum);
System.Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
byte[,] array2DRotation = RotationOn90Degree(array2D, subArr, elementsNum);
Print2DArray(array2DRotation, elementsNum, subArr);

byte[,] RotationOn90Degree(byte[,] array2D, byte subArrayCount, byte elementsCount)
{
  byte[,] rotation2Darr = new byte[elementsCount, subArrayCount];
  // byte[] arrFrom2Darr = new byte[elementsCount*subArrayCount];
  // byte index = 0;
  for(byte i = 0; i < elementsCount; i++)
    for(byte j = 0; j < subArrayCount; j++)
      {
        rotation2Darr[i, j] = array2D[j, i];
        // arrFrom2Darr[index] = array2D[j, i];
        // index++;
      }
  /*for(byte i = 0; i < elementsNum; i++)
  {
    byte[] arrFromColumn = ArrayFromColumn(subArrayCount, i, array2D);
    for(byte j = 0; j < subArrayCount; j++)
      rotation2Darr[i, j] = arrFromColumn[j];
  }*/
  return rotation2Darr;
}
/*
byte[] ArrayFromColumn(byte row, byte i, byte[,] array2D)
{
  byte[] array = new byte[row];
  for(byte j = 0; j < row; j++) array[j] = array2D[j, i];
  return array;
}
*/
byte[,] Fill2DemArray
(byte subArrayCount, byte elementsCount, byte minElementsValue, byte maxElementsValue)
{
  byte[,] arr2D = new byte[subArrayCount, elementsCount];
  for(byte i = 0; i < subArrayCount; i++)
    for(byte j = 0; j < elementsCount; j++)
      arr2D[i, j] = (byte)new Random().Next(minElementsValue, maxElementsValue + 1);
  return arr2D;
}

void Print2DArray(byte[,] array2D, byte subArrayCount, byte elementsCount)
{
  for(byte i = 0; i < subArrayCount; i++)
    { 
      for(byte j = 0; j < elementsCount; j++)
        System.Console.Write(array2D[i, j] + " ");
      System.Console.WriteLine();
    }  
}