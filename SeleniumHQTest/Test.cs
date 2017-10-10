using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Alerts_and_Windows
{

    [TestFixture]
    class SeleniumHQTest
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }


        public IWebElement waitForPageUntillElementIsVissable(By locator, int maxseconds)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(maxseconds))
                .Until(ExpectedConditions.ElementExists((locator)));
        }

        public void waitOnPage(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
        }


        [TearDown]
        public void teardown()
        {
            //driver.Close();
           // driver.Quit();
        }
      
        [Test]
        public void SeleniumHQTest()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/ul/li[5]/a")).Click();
            driver.findElement(By.XPath("/html/body/div/div[2]/div[2]/div/h3[1]/a")).Click();

            
        }

        

    }
}