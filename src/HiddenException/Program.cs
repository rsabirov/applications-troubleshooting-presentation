using System;

namespace HiddenException
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      try
      {
        throw new Exception("Very important exception");
      }
      catch (Exception e)
      {
          // Case1: not logging/rethrowing the exception
          Console.WriteLine("Something went wrong!");

          // Case2: throwing other exception with hiding original
          //throw new Exception("Something went wrong!");
      }
    }
  }
}