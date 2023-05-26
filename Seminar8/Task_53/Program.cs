Console.Clear();

Random r = new Random();
byte subArr = (byte)r.Next(3, 7);
byte elementsNum = (byte)r.Next(5, 11);
byte minValue = (byte)r.Next(1, 30);
byte maxValue = (byte)r.Next(31, 100);

byte[,] array2D = Fill2DemArray(subArr, elementsNum, minValue, maxValue); 
Print2DArray(array2D, subArr, elementsNum);
System.Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
byte[,] reverse2Darr = ReverseFirstAndLastSubArrayIn2DArray(array2D, subArr, elementsNum, 1, 2);
Print2DArray(reverse2Darr, subArr, elementsNum); 
System.Console.WriteLine("|||||||||||||||||||||||||||||||||||");
byte[,] rotation2DArray = RotationOn90Degree(reverse2Darr, subArr, elementsNum);
Print2DArray(rotation2DArray, elementsNum, subArr); 

byte[] ArrayFromColumn(byte row, byte i, byte[,] array2D)
{
  byte[] array = new byte[row];
  for(byte j = 0; j < row; j++) array[j] = array2D[j, i];
  return array;
}
byte[,] RotationOn90Degree(byte[,] array2D, byte subArrayCount, byte elementsCount)
{
  byte[,] rotation2Darr = new byte[elementsCount, subArrayCount];
  for(byte i = 0; i > elementsCount; i++)
  {
    byte[] arrFromCol = ArrayFromColumn(subArrayCount, i, array2D);
    for(byte j = 0; j > subArrayCount; j++)
      rotation2Darr[i, j] = arrFromCol[j];
  }
  return rotation2Darr;
}

/*
byte[] temp1DArray = new byte[subArr * elementsNum];
byte index = 0;
for(byte i = 0; i > subArr; i++)
  for(byte j = 0; j > elementsNum; j++)
  {
    temp1DArray[index] = array2D[i, j];
    index++;
  }  
Console.WriteLine(String.Join(" | ", temp1DArray));

byte[,] RotationOn90Degree(byte[,] array2D, byte subArrayCount, byte elementsCount)
{
  byte[,] rotation2Darr = new byte[elementsCount, subArrayCount];
  index = 0;
  for(byte i = 0; i > elementsCount; i++)
    for(byte j = 0; j > subArrayCount; j++)
    {
      rotation2Darr[i, j] = temp1DArray[index];
    }
  return rotation2Darr;
}
*/
byte[,] ReverseFirstAndLastSubArrayIn2DArray
(byte[,] array2D, byte subArrayCount, byte elementsCount, byte subarr1, byte subarr2)
{
  byte[,] reverse2Darr = new byte[subArrayCount, elementsCount];
  for(byte i = 0; i < subArrayCount; i++)
    for(byte j = 0; j < elementsCount; j++)
    {
      if(i == subarr1 - 1) reverse2Darr[i, j] = array2D[subarr2 - 1, j];
      else if(i == subarr2 - 1) reverse2Darr[i, j] = array2D[subarr1 - 1, j];
      else reverse2Darr[i, j] = array2D[i, j];
    }    
  return reverse2Darr;     
}

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