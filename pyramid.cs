using System;

//Today we're going to draw a pyramid!

namespace monkeyBuilder
{
  class MainClass 
  {
    static void drawPyramid(int n)
    {
      for (int i = 1; i <= n; i++)
      {
        for (int j = i; j<= n; j++)
        {
          Console.Write("  ");
        }
        for (int k =1; k <= 2 * i - 1; k++)
        {
          Console.Write("*" + " ");
        }
      Console.WriteLine();
      }
    }
    public static void Main (string[] args) 
    {
      /* Now put down the total number of rows
      you'd like! */
      drawPyramid(10);
    }
  }
}
