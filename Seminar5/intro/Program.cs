// Создать массив из 12 элементов и найти сумму отрицательных и положительных элементов.
Console.Clear();

int lengthMassive = 12;

int[] massive = CreateArray(lengthMassive);

PrintArray(massive, lengthMassive);
//System.Console.Write("[" + String.Join(" | ", massive) + "]");
int sumNegative = 1, sumPositive = -1;
sumNegative = SumNegativeOrPositiveNumber(massive, sumNegative, 0);
sumPositive = SumNegativeOrPositiveNumber(massive, 0, sumPositive);
//sumPositive = SumPositiveNumber(massive);
System.Console.WriteLine("------" + sumNegative + " ** " + sumPositive);

int[] CreateArray(int len)
{
  int[] array = new int[len];
  for(byte i = 0; i < len; i++)
  {
    array[i] = new Random().Next(-10, 10);
  }
  return array;
}
void PrintArray(int[] array, int len)
{
  System.Console.Write("[");
  for(byte i = 0; i < len - 1; i++) System.Console.Write(array[i] + "; ");
  System.Console.Write(array[len - 1] + "]");
}
int SumNegativeOrPositiveNumber(int[] array, int sumNeg, int sumPos)
{
  if (sumNeg == 0)
  {
    for(int i = 0; i < array.Length; i++)
    {
      if(array[i] > 0) sumPos += array[i];
    }
    return sumPos + 1;
  }
  else
  {
    for(int i = 0; i < array.Length; i++)
    {
      if(array[i] < 0) sumNeg += array[i];
    }
    return sumNeg - 1;
  } 
}
