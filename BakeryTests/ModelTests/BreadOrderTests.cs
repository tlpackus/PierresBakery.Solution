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
  }
} 