using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(1);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrdered_Int()
    {
      int orderedBread = 1;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      int result = newBreadOrder.OrderedBread;
      Assert.AreEqual(orderedBread, result);
    }

    [TestMethod]
    public void BreadOrderPrice_ReturnsBreadTotalPriceBuyingOneLoaf_int()
    {
      int orderedBread = 1;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      int result = newBreadOrder.BreadOrderPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void BreadOrderPrice_ReturnsBreadTotalPriceIfBuying3WithDeal()
    {
      int orderedBread = 3;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      int result = newBreadOrder.BreadOrderPrice();
      Assert.AreEqual(10, result);
    }
  }
} 