Console.Clear();

double num1 = double.Parse(Console.ReadLine() ?? "");
double num2 = double.Parse(Console.ReadLine() ?? "");
double num3 = double.Parse(Console.ReadLine() ?? "");
bool result = TriangleCheck(num1, num2, num3);
System.Console.WriteLine(result);

bool TriangleCheck(double n1, double n2, double n3)
{
  if(n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1) 
    return true;
  else
    return false;
}