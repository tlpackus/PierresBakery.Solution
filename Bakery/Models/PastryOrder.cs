namespace Bakery.Models
{
  public class PastryOrder
  {
    public int OrderedPastry { get; set; }

    public PastryOrder(int pastryOrder)
    {
      OrderedPastry = pastryOrder;
    }

    public int PastryOrderPrice()
    {
      if (OrderedPastry % 3 == 0)
      {
        int pastryPrice = ((OrderedPastry * 2) - (OrderedPastry / 3));
        return pastryPrice;
      }
      else
      {
        return OrderedPastry * 2;
      }
    }
  } 
}