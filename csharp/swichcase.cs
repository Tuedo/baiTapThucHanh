using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day) 
      {
        case 1:
          Console.WriteLine("DO Duc Tue Monday");
          break;
        case 2:
          Console.WriteLine("DO Duc TueTuesday");
          break;
        case 3:
          Console.WriteLine("DO Duc TueWednesday");
          break;
        case 4:
          Console.WriteLine("DO Duc TueThursday");
          break;
        case 5:
          Console.WriteLine("DO Duc TueFriday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
      }    
    }
  }
}