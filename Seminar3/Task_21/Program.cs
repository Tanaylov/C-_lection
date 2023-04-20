Console.Clear();
double X1 = 0, Y1 = 0, X2 = 0, Y2 = 0;

Console.WriteLine("To find the distance between the points, enter their value.");

checkingOnValid (ref X1, "X_1");
checkingOnValid (ref Y1, "Y_1");
checkingOnValid (ref X2, "X_2");
checkingOnValid (ref Y2, "Y_2");

Distance (X1, Y1, X2, Y2);

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

static void Distance (double X1, double Y1, double X2, double Y2 )
{
  double resalt = Math.Sqrt((X1 - X2)*(X1 - X2) + (Y1 - Y2)*(Y1 - Y2));
  Console.WriteLine(resalt); 
}