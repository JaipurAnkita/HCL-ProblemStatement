using HCL_Test.Controllers;
using HCL_Test.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace HCL_Test.tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Series series = new Series();
            series.Divisor = 3;
            series.Number = 1;
            series.Output = 3;
            HomeController controller = new HomeController();
            var result = controller.Index(series) as ViewResult;
            var modelResult = result.Model as Series;
            Assert.AreEqual(series.Output, modelResult.Output);

                }

        [Test]
        public void Test2()
        {
            Series series = new Series();
            series.Divisor = 3;
            series.Number = 1;
            series.Output = 3;
            HomeController controller = new HomeController();
            var result = controller.Index(series) as ViewResult;
            var modelResult = result.Model as Series;
            Assert.AreEqual(series.Output, modelResult.Output);

        }

        [Test]
        public void Test3()
        {
            Series series = new Series();
            series.Divisor = 3;
            series.Number = 2;
            series.Output = 9;
            HomeController controller = new HomeController();
            var result = controller.Index(series) as ViewResult;
            var modelResult = result.Model as Series;
            Assert.AreEqual(series.Output, modelResult.Output);

        }

        [Test]
        public void Test4()
        {
            Series series = new Series();
            series.Divisor = 3;
            series.Number = 3;
            series.Output = 57;
            HomeController controller = new HomeController();
            var result = controller.Index(series) as ViewResult;
            var modelResult = result.Model as Series;
            Assert.AreEqual(series.Output, modelResult.Output);

        }

        [Test]
        public void Test5()
        {
            Series series = new Series();
            series.Divisor = 5;
            series.Number = 1;
            series.Output = 5;
            HomeController controller = new HomeController();
            var result = controller.Index(series) as ViewResult;
            var modelResult = result.Model as Series;
            Assert.AreEqual(series.Output, modelResult.Output);

        }
        [Test]
        public void Test6()
        {
            Series series = new Series();
            series.Divisor = 5;
            series.Number = 2;
            series.Output = 105;
            HomeController controller = new HomeController();
            var result = controller.Index(series) as ViewResult;
            var modelResult = result.Model as Series;
            Assert.AreEqual(series.Output, modelResult.Output);

        }


    }

}