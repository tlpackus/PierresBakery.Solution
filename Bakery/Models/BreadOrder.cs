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
      if (OrderedBread > 2)
      {
        int breadPrice = ((OrderedBread * 5) - (OrderedBread / 3) * 5);
        return breadPrice;
      }
      else
      {
        return OrderedBread * 5;
      }
    }
  }
} 