Console.Clear();
/*
for (int i = 1; i <= 10; i ++)
{
  for (int j = 1; j <= 10; j ++)
  {
    Console.WriteLine($"{i} x {j} = {i * j}");
  }
  Console.WriteLine();
}
*/

string Text(string text1)
{
  string text2 = text1.Replace(' ','_').Replace('П','п');
  return text2;
}

string textM = Text("Привет - это я.");
Console.Write(textM);