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
      }
    }
  }
}