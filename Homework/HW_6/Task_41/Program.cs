// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
Console.Clear();

float [] userArray = GetArrayFromUser();
byte result = CountPositiveNumbers(userArray);
PrintSolusion(userArray, result);

float GetDataFromUser(string text)
{
  float num;
  while(true)
  {
    Console.WriteLine($"Enter {text}");
    if(float.TryParse(Console.ReadLine().Replace('.',','), out num))
      break;
    Console.WriteLine("Wrong number."); 
  } 
  return num;
}

float [] GetArrayFromUser()
{
  byte len = Convert.ToByte(GetDataFromUser("length of array"));
  float[] array = new float[len];
  byte j = 1;
  for(byte i = 0; i < len; i++) 
  {
    array[i] = GetDataFromUser($"{j} number");
    j++;
  }
  return array;
}

byte CountPositiveNumbers(float[] array)
{
  byte count = 0;
  foreach(float elem in array)
    if(elem > 0) count++;
  return count;
}

void PrintSolusion(float[] array, int number)
{
  System.Console.Write("[");
  System.Console.WriteLine(String.Join(" / ", array) + "] --->> " + number +" positive number(s).");
} 
