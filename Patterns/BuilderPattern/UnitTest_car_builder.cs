using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleExample
{
  [TestClass]
    public class UnitTest_car_builder
    {
        [TestMethod]
        public void TestMethod_Build_a_car()
        {
            var carBuilder = new CarBuilder();

            var car = carBuilder
                .Blue()
                .ToyotaPrius()
                .Fast()
                .Build();

            Assert.AreEqual("Blue", car.Color);
        }
    }
}
