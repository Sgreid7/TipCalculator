using System;

namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // Welcome the User 
      Console.WriteLine("Welcome User!");
      // Ask how much the bill was
      Console.WriteLine("How much was your meal?");
      var total = Console.ReadLine();
      // Calculate 18%
      var tip = Double.Parse(total) * 0.18;
      // Add tip to the total
      var grandTotal = tip + Double.Parse(total);
      // display the the result
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("The 18% tip is " + tip);
      Console.WriteLine("Grand total is " + grandTotal);
    }
  }
}
