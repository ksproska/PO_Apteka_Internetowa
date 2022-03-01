using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

using System.Collections.ObjectModel;

using System.IO;

namespace TestingAptekaPO
{
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://localhost:44393/");
            driver.FindElement(By.Id("search-button")).Click();

            // example filters set
            driver.FindElement(By.Id("PrescriptionButton")).Click();
            driver.FindElement(By.Id("AveilableButton")).Click();
            new SelectElement(driver.FindElement(By.Id("ProductTypeList"))).SelectByText("leki");

            // example sorter set
            new SelectElement(driver.FindElement(By.Id("SortersList"))).SelectByText("Price up");
        }
        
        public void MySleep() { System.Threading.Thread.Sleep(2500); }

        [Test]
        public void TestCrudShoppingCart()
        {
            MySleep();
            
            // add first element from list
            var baseTable = driver.FindElement(By.Id("product-name-list"));
            var tableRows = baseTable.FindElements(By.TagName("tr"));
            int index = 0;
            tableRows[index].FindElement(By.ClassName("shopping-cart-button")).Click();

            MySleep();

            // add second element from list
            baseTable = driver.FindElement(By.Id("product-name-list"));
            tableRows = baseTable.FindElements(By.TagName("tr"));
            index = 1;
            tableRows[index].FindElement(By.ClassName("shopping-cart-button")).Click();
            
            // check if added
            MySleep();
            int iCartCountDiff1 = int.Parse(driver.FindElement(By.ClassName("cartcount")).Text);
            Assert.IsTrue(iCartCountDiff1 == 2);

            // open details of third element
            baseTable = driver.FindElement(By.Id("product-name-list"));
            tableRows = baseTable.FindElements(By.TagName("tr"));
            index = 2;
            tableRows[index].FindElement(By.ClassName("product-name-picture")).Click();

            // add 3 product names
            MySleep();
            driver.FindElement(By.Id("plus-button")).Click();
            driver.FindElement(By.Id("plus-button")).Click();
            driver.FindElement(By.Id("plus-button")).Click();

            // check if added
            MySleep();
            int iCartCountDiff2 = int.Parse(driver.FindElement(By.ClassName("cartcount")).Text);
            Assert.IsTrue(iCartCountDiff2 == iCartCountDiff1 + 3);

            // remove one product name
            MySleep();
            driver.FindElement(By.Id("minus-button")).Click();

            // check if removed
            MySleep();
            int iCartCountDiff3 = int.Parse(driver.FindElement(By.ClassName("cartcount")).Text);
            Assert.IsTrue(iCartCountDiff3 == iCartCountDiff2 - 1);

            // open shopping cart
            driver.FindElement(By.Id("shopping-cart-button")).Click();

            // add one
            MySleep();
            baseTable = driver.FindElement(By.Id("product-name-list"));
            tableRows = baseTable.FindElements(By.TagName("tr"));
            index = 0;
            tableRows[index].FindElement(By.ClassName("plus-cart")).Click();


            // add one
            MySleep();
            baseTable = driver.FindElement(By.Id("product-name-list"));
            tableRows = baseTable.FindElements(By.TagName("tr"));
            index = 0;
            tableRows[index].FindElement(By.ClassName("minus-cart")).Click();


            // add one
            MySleep();
            
            baseTable = driver.FindElement(By.Id("product-name-list"));
            tableRows = baseTable.FindElements(By.TagName("tr"));
            index = 0;

            int beforeBinCount = int.Parse(tableRows[index].FindElement(By.ClassName("product-name-count")).Text);
            tableRows[index].FindElement(By.ClassName("bin-cart")).Click();
            
            // check if changes correct
            int iCartCountDiff4 = int.Parse(driver.FindElement(By.ClassName("cartcount")).Text);
            Assert.IsTrue(iCartCountDiff4 == iCartCountDiff3 - beforeBinCount);
            MySleep();
            MySleep();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}