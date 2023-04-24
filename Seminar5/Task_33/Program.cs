Console.Clear();
int len = 0, start = 0, finish = 0, num = 0;
int lenAr = GetDateFromUser(ref len, "length");
int startArr = GetDateFromUser(ref start, "start");
int finishArr = GetDateFromUser(ref finish, "finish");
int searchingNum = GetDateFromUser(ref num, "number");

int [] arrayS = GetArray(lenAr, startArr, finishArr);

System.Console.WriteLine(String.Join(" ** ", arrayS));
CheckingForNumber(arrayS, searchingNum);

int [] GetArray(int lenAr, int startArr, int finishArr)
{
  int [] array = new int[lenAr];
  for(byte i = 0; i < lenAr; i++)
    array[i] = new Random().Next(startArr, finishArr);
  return array;  
}

int GetDateFromUser(ref int dates, string date)
{
 System.Console.WriteLine($"Enter {date}");
 dates = Convert.ToInt32(Console.ReadLine());
 return dates;
}

void CheckingForNumber(int [] array, int number)
{
  int count = 0;
  foreach(int el in array) if(el == number) count++;

  if(count != 0) System.Console.WriteLine($"Yes, {count} times");
  else System.Console.WriteLine("NO");
}