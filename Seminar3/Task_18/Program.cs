Console.Clear();

int quarter = 0;
CheckingOnValid (ref quarter);
PrintValueXY (quarter);

static void CheckingOnValid (ref int userInput)
{
  while(true)
  {
    try
    {
      Console.Write("Enter the number of quarter (1-4): ");
      userInput = int.Parse(Console.ReadLine().Replace('.',',') ?? "");
      if (userInput > 0 && userInput < 5)
      break;
    }
    catch(Exception exc)
    {
      Console.WriteLine($"Entered an invalid value. {exc.Message}");
    }
  }
}

static void PrintValueXY (int userInput)
{
  if (userInput == 1)
  {
    Console.WriteLine("First quarter: X > 0; Y > 0.");
  }
  else if (userInput == 2)
  {
    Console.WriteLine("Second quarter: X < 0; Y > 0.");
  }
  else if (userInput == 3)
  {
    Console.WriteLine("Third quarter: X < 0; Y < 0.");
  }
  else if (userInput == 4)
  {
    Console.WriteLine("Fourth quarter: X > 0, Y < 0.");
  }
  // else
  // {
  //   Console.WriteLine("You entered wrong value of quarter.");
  // }
}

