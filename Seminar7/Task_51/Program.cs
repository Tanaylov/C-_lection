Console.Clear();

byte numSubArr = GetUserNumberToDetectDimensionality("Enter the number of subarray: ", 
error: "You entered the wrong number or not a number.");
byte numElements = GetUserNumberToDetectDimensionality(error: "You entered the wrong number or not a number",
enter: "Enter the number of elements in the subarray: " );
float minV = CheckForMinMaxValue(1, 0);
float maxV = CheckForMinMaxValue(0, 1);

float[,] our2Darray = Fill2DArray(numSubArr, numElements, minV, maxV);
Print2DimensionArray(our2Darray);

float result = SumElementsOnMainDiagonal(our2Darray);
System.Console.WriteLine(result);

float CheckForMinMaxValue(byte min, byte max)
{
  float minValue;
  float maxValue;
  while(true)
  {
    minValue = GetUserNumberForMinMaxValue(enter: "Enter the Min value for the array: ", 
    error: "You entered the wrong number or not a number.");
    maxValue = GetUserNumberForMinMaxValue(enter: "Enter the Max value for the array: ", 
    error: "You entered the wrong number or not a number.");
    if(minValue < maxValue) break;
    System.Console.WriteLine("Min value is greater than Max value, please, enter correct data.");
  }
  if(min == 1) return minValue;
  else return maxValue;
}

float[,] Fill2DArray(byte subarray, byte elements, float min, float max)
{
  float[,] arr2dem = new float[subarray, elements];
  for(byte i = 0; i < subarray; i++)
    for(byte j = 0; j < elements; j++)
      arr2dem[i, j] = (float)Math.Round((float)new Random().NextDouble() * (max - min) + min, 1);
  return arr2dem;
}

void Print2DimensionArray(float[,] d2arr)
{
  float[] arr = new float[d2arr.GetLength(1)];
  for(byte i = 0; i < d2arr.GetLength(0); i++)
  {
    for(byte j = 0; j < d2arr.GetLength(1); j++) arr[j] = d2arr[i, j];
    System.Console.Write("{ " + String.Join(" | ", arr) + " }");
    System.Console.WriteLine();
  }  
}

float GetUserNumberForMinMaxValue (string enter, string error)
{
  float num;
  while(true)
  {
    System.Console.Write(enter);
    if(float.TryParse(Console.ReadLine().Replace('.' , ','), out num))
      break;
    System.Console.WriteLine(error);
  }
  return num;
}

byte GetUserNumberToDetectDimensionality (string enter, string error)
{
  byte num;
  while(true)
  {
    System.Console.Write(enter);
    if(byte.TryParse(Console.ReadLine() ?? "", out num) && num > 0)
      break;
    System.Console.WriteLine(error);
  }
  return num;
}

float SumElementsOnMainDiagonal(float[,] arr)
{
  float result = 0;
  for(byte i = 0; i < arr.GetLength(0); i++)
    for(byte j = 0; j < arr.GetLength(1); j++)
      {
        if(i == j) result += arr[i, j];
      }
  return (float)Math.Round(result, 1);    
}