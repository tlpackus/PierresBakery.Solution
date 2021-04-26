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
      return OrderedBread * 5;
    }
  }
} 