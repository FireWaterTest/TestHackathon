using FireWater.Test.PageObjects.expedia;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageTests.expedia
{
    [TestFixture]

    public class MainPageTests : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://newtours.demoaut.com/mercurysignon.php";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var usr = new MainPage(driver);

            usr.addUser("test", "test");

            string result = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/big/blockquote/blockquote/font/center/b")).Text;

            Assert.AreEqual(result, "**Failed Login**");

        }

    }
}
