Console.Clear();

double valueX;
double valueY;

while(true)
{
  Console.Write("Enter X-axis value: ");
  if (double.TryParse(Console.ReadLine().Replace('.',','), out valueX) && valueX != 0)
  break;
  Console.WriteLine("You entered an invalid value.");
}

while(true)
{
  Console.Write("Enter Y-axis value: ");
  if (double.TryParse(Console.ReadLine().Replace('.',','), out valueY) && valueY != 0)
  break;
  Console.WriteLine("You entered an invalid value.");
}

//Console.Write("Enter X-axis value: ");
//double valueX = double.Parse(Console.ReadLine().Replace('.',',') ?? "");

//Console.Write("Enter Y-axis value: ");
//double valueY = double.Parse(Console.ReadLine().Replace('.',',') ?? "");

//Console.Write(valueX + valueY);

if (valueX > 0 && valueY > 0)
{
  Console.WriteLine("First quarter");
}
else if (valueX < 0 && valueY > 0)
{
  Console.WriteLine("Second quarter");
}
else if (valueX < 0 && valueY < 0)
{
  Console.WriteLine("Third quarter");
}
else if (valueX > 0 && valueY < 0)
{
  Console.WriteLine("Fourth quarter");
}

/*
else
{
  Console.WriteLine("одна из координат лежит на оси");
}
*/