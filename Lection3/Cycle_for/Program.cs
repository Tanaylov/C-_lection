Console.Clear();
/*
for (int i = 2; i <= 10; i ++)
{
  for (int j = 2; j <= 10; j ++)
  {
    Console.WriteLine($"{i} x {j} = {i * j}");
  }
  Console.WriteLine();
}


string Text(string text1)
{
  string text2 = String.Empty; // Как int number = 0;
  text2 = text1.Replace(' ','_').Replace('П','п');
  return text2;
}

string textM = Text("Привет - это я.");
Console.Write(textM);
*/
/*
string text = "aaaaaddddd,,,,eee"
            + "45kkkkkoo./.k7891";
System.Console.WriteLine(text);
System.Console.WriteLine();
char a = 'e';
char b = 'E';
char a1 = 'd';
char b1 = '1';
text = ModText(text, a, b);
System.Console.WriteLine(text);
System.Console.WriteLine();
text = ModText(text, a1, b1);
System.Console.WriteLine(text);

string ModText(string text, char origine, char modify)
{
  string textNew = String.Empty;
  for (int i = 0; i < text.Length; i++)
  {
    if(text[i] == origine) textNew += modify;
    else textNew += text[i];
  }
  return textNew;
}  
*/

int [] array = {9, 7, 1, 11, 20, 5};

for(int i = 0; i < array.Length - 1; i++)
{
  int maxPos = i;
  for(int j = i + 1; j < array.Length; j++)
  {
    if(array[maxPos] < array[j]) maxPos = j;
  }
  int temp = array[i];
  array[i] = array[maxPos];
  array[maxPos] = temp;
}
System.Console.WriteLine(string.Join("/", array));