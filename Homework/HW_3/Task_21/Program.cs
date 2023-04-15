// D= корень квадратный из ((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2) - Нахождение расстояния между точками в 3D пространстве

Console.Clear();

double userN1;
double userN2;
double userN3;

Console.WriteLine("Enter coordinates for the three-dimensional point 'N'");
while (true)
{
  if(double.TryParse(Console.ReadLine(), out userN1) && 
     double.TryParse(Console.ReadLine(), out userN2) &&
     double.TryParse(Console.ReadLine(), out userN3)
    )
  break;
  Console.WriteLine("You entered not a number, please, try again starting from the first coordinate");
}

double userA1;
double userA2;
double userA3;

Console.WriteLine("Enter coordinates for the three-dimensional point 'A'");
while (true)
{
  if(double.TryParse(Console.ReadLine(), out userA1) && 
     double.TryParse(Console.ReadLine(), out userA2) &&
     double.TryParse(Console.ReadLine(), out userA3)
    )
  break;
  Console.WriteLine("You entered not a number, please, try again starting from the first coordinate");
}

double pointX = (userN1 - userA1) * (userN1 - userA1);
double pointY = (userN2 - userA2) * (userN2 - userA2);
double pointZ = Math.Pow((userN3 - userA3), 2);
double distance = Math.Pow((pointX + pointY + pointZ), 1/2d);

Console.WriteLine($"N({userN1},{userN2},{userN3}); A({userA1},{userA2},{userA3}) -> {distance}");

