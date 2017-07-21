using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var controller = new ValuesController();

            //Act
            Double BMI = controller.CalculeBMI(63, 1.75);
           
            //Assert

            Assert.AreNotEqual(0, BMI);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var controller = new ValuesController();

            //Act
            Double BMI = controller.CalculeBMI(0, 1.75);
       
            //Assert
            Assert.AreNotEqual(0, BMI);

        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var controller = new ValuesController();

            //Act
            Double BMI = controller.CalculeBMI(0, 1.75);

            //Assert
            Assert.AreNotEqual(0, BMI);

        }

    }
}
