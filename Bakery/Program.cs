using System;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome To Pierre's Bakery!");
      Console.WriteLine("Our world renowned Bread and Pastry's are on sale today!");
      Console.WriteLine("BREAD is $5 a loaf.");
      Console.WriteLine("DEAl: Buy 2 get 1 free!");
      Console.WriteLine("PASTRY'S are $2 each.");
      Console.WriteLine("DEAL: 3 for $5!");
      Console.WriteLine("How many loaves of bread would you like?");
      int orderedBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int orderedPastry = int.Parse(Console.ReadLine());

      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      PastryOrder newPastryOrder = new PastryOrder(orderedPastry);
    }
  }
}