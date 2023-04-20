Console.Clear();

double valueX = 0, valueY = 0;

static void checkingOnValid (ref double userInPut, string axis)
{
  while(true)
  {
    try
    {
      Console.Write($"Enter {axis}-value: ");
      userInPut = double.Parse(Console.ReadLine() ?? "".Replace('.',','));
      break;
    }
    catch(Exception exc)
    {
      Console.WriteLine($"Entered an invalid value. {exc.Message}");
    }
  }
}
checkingOnValid(ref valueX, "X");
checkingOnValid(ref valueY, "Y");

/*
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
*/

/*
try
{
  Console.Write("Enter X-axis value: ");
  valueX = double.Parse(Console.ReadLine().Replace('.',',') ?? "");

  Console.Write("Enter Y-axis value: ");
  valueY = double.Parse(Console.ReadLine().Replace('.',',') ?? "");
}
catch(Exception exc)
{
  Console.Write($"Entered an invalid value {exc.Message}");
  return;
}
*/
static void PrintQuaterOfCoordinates (double valueX, double valueY)
{
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
  else
  {
    Console.WriteLine("One of the coordinates lies on the axis");
  }
}

PrintQuaterOfCoordinates (valueX, valueY);