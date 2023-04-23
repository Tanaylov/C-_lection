// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2.
Console.Clear();

int [] array3dig = CreatThreeDigitsArray();
PrintArray(array3dig);
ushort countEvenNumber = CountEvenNumberInArray (array3dig);
PrintResult(array3dig, countEvenNumber);


void PrintResult (int[] array, ushort count)
{
  Console.WriteLine("[" + String.Join(" | ", array) + "]. " + "Count of even numbers equal " + count);
}

void PrintArray(int[] array)
{
  Console.WriteLine("[" + String.Join(" | ", array) + "]");
}

int[] CreatThreeDigitsArray()
{
  int lenAr = new Random().Next(3, 10);
  int [] array = new int[lenAr];
  for(byte i = 0; i < lenAr; i++) array[i] = new Random().Next(100, 1000);
  return array;
}

ushort CountEvenNumberInArray(int[] array)
{
  ushort count = 0;
  for(byte i = 0; i < array.Length; i++) 
  {
    if(array[i] % 2 == 0) count++;
  }
  return count;
}