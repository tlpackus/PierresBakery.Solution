using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreatesInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(1);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }
    [TestMethod]
    public void GetPastryOrder_ReturnsPastriesOrdered_Int()
    {
      int orderedPastry = 1;
      PastryOrder newPastryOrder = new PastryOrder(1);
      int result = newPastryOrder.OrderedPastry;
      Assert.AreEqual(orderedPastry, result);
    }
  } 
}