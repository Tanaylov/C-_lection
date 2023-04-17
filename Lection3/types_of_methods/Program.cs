// 1 Type - ничего не принимает на вход и ничего не возвращает.

void Method1()
{
  Console.Clear();
  Console.WriteLine("Hello, Ivan!");
}

Method1 ();


//2 Type - принимает на вход переменные, но ничего не возвращает.

void Method2(string name)
{
  //Console.Clear();
  Console.WriteLine($"Hello, {name}!");
}

Method2 ("Anna");

void Method2_1(string name, int c)
{
  int i = 0;
  while(i < c)
  {
    Console.WriteLine($"Hello, {name}! - {c}");
    i ++;
  }
}

Method2_1("Annna", 2);
Method2_1 (c: 3, name: "Anna");


//3 Type - ничего не принимает на вход, но возвращает значение.

int Method3()
{
  return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


//4 Type - И принимает на вход значение и возвращает какие-то значениея.

string Method4 (int count, string text)
// {
//   int index = 0;
//   string result = String.Empty;
//   while (index < count)
//   {
//     result += text;
//     index ++;
//   }
//   return result;
// }
{
  string result = String.Empty;
  for (int index = 0; index < count; index ++)
    result += text;
  return result;
}

string res = Method4(3, "Hi++-");
Console.WriteLine(res);