// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

float b1 = GetDataFromUser("b1");
float k1 = GetDataFromUser("k1");
float b2 = GetDataFromUser("b2");
float k2 = GetDataFromUser("k2");

float valueY = XAxisCrossPoint(b1, k1, b2, k2);
float valueX = YAxisCrossPoint(valueY, b1, k1);
System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -->> ({valueX}; {valueY})");

float XAxisCrossPoint(float b1, float k1, float b2, float k2)
{
  valueY = (b2 - k2*b1/k1) / (1-k2/k1);
  return valueY;
}

float YAxisCrossPoint(float y, float b1, float k1)
{
  valueX = (y - b1) / k1;
  return valueX;
}

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