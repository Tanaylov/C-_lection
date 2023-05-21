Console.Clear();
/*
string res = NumbersInIntervalRec(12, 11);
System.Console.WriteLine(res);
NumbersInInterval(19, 11);

void NumbersInInterval(byte a, byte b)
{
  string interval = String.Empty;
  for(byte i = a; i >= b; i--){
    // if(a == b) interval += a;
    // else 
    interval += i + ", ";
    }
  interval = interval.Remove(interval.Length - 2);
  System.Console.Write(interval);  
}

string NumbersInIntervalRec(int a, byte b)
{
  if(a < b) return $"{a}, " + NumbersInIntervalRec(a + 1, b); 
  else return $"{a}";
}
*/
Sum(7);
short summa1 = SumRec(7);
System.Console.WriteLine(summa1);

void Sum(short n)
{
  short summa = 0;
  for(short i = 1; i <= n; i++)
    summa += i;
  System.Console.WriteLine(summa);
}

short SumRec(int n)
{
  if(n == 0) return 0;
  else return Convert.ToInt16(n + SumRec(n - 1));
}


