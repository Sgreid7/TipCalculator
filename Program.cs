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
      // Ask how was the service
      Console.WriteLine("How was your service today?");
      Console.WriteLine("Valid options are: okay, good, and great");
      var service = Console.ReadLine();
      // okay, good, great, default
      // Calculate tip based on level of service
      var tipPercentage = 0.15;

      if (service == "okay")
      {
        tipPercentage = 0.18;
      }
      else if (service == "good")
      {
        tipPercentage = 0.20;
      }
      else if (service == "great")
      {
        tipPercentage = 0.25;
      }

      var tip = Double.Parse(total) * tipPercentage;
      // Add tip to the total
      var grandTotal = tip + Double.Parse(total);
      // display the the result
      // tipPercent * 100 will give correct value
      var tipDisplay = tipPercentage * 100;
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("The " + tipDisplay + "% tip is " + tip);
      Console.WriteLine("Grand total is " + grandTotal);
    }
  }
}
