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
    class Tests2
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://localhost:44393/");
            driver.FindElement(By.Id("search-button")).Click();
        }

        public void MySleep() { System.Threading.Thread.Sleep(2500); }

        [Test]
        public void TestExploringShop()
        {
            // check if start setup correct
            Assert.IsFalse(driver.FindElement(By.Id("PrescriptionButton")).Selected);
            Assert.IsTrue(driver.FindElement(By.Id("AveilableButton")).Selected);

            // example filters set
            MySleep();
            driver.FindElement(By.Id("PrescriptionButton")).Click();
            MySleep();
            driver.FindElement(By.Id("AveilableButton")).Click();
            MySleep();
            new SelectElement(driver.FindElement(By.Id("ProductTypeList"))).SelectByText("leki");

            // example sorter set
            MySleep();
            new SelectElement(driver.FindElement(By.Id("SortersList"))).SelectByText("Price up");

            // check if filters and sorters displayed
            Assert.IsTrue(driver.FindElement(By.Id("PrescriptionButton")).Selected);
            Assert.IsFalse(driver.FindElement(By.Id("AveilableButton")).Selected);
            Assert.IsTrue(new SelectElement(driver.FindElement(By.Id("ProductTypeList"))).SelectedOption.Text == "leki");
            Assert.IsTrue(new SelectElement(driver.FindElement(By.Id("SortersList"))).SelectedOption.Text == "Price up");

            // example filters set
            MySleep();
            driver.FindElement(By.Id("PrescriptionButton")).Click();
            MySleep();
            new SelectElement(driver.FindElement(By.Id("ProductTypeList"))).SelectByText("All types");

            MySleep();
            
            driver.FindElement(By.Id("SearchContentInput")).SendKeys("Apap");
            driver.FindElement(By.Id("SearchButton")).Click();
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
