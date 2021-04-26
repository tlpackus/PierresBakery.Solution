namespace Bakery.Models
{
  public class PastryOrder
  {
    public int OrderedPastry { get; set; }

    public PastryOrder(int pastryOrder)
    {
      OrderedPastry = pastryOrder;
    }
  }
} 