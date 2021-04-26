namespace Bakery.Models
{
  public class BreadOrder
  {
    public int OrderedBread { get; set; }
    public BreadOrder(int breadOrder)
    {
      OrderedBread = breadOrder;
    }
    public int BreadOrderPrice()
    {
      if (OrderedBread % 3 == 0)
      {
        int breadPrice = (OrderedBread - (OrderedBread / 3)) * 5;
        return breadPrice;
      }
      else
      {
        return OrderedBread * 5;
      }
    }
  }
} 