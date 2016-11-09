using FireWater.Test.PageObjects.thedemositecouk;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageTests.thedemositecouk
{
    /// <summary>
    /// http://thedemosite.co.uk/login.php
    /// username: test
    /// password: test
    /// </summary>
    public class ThedemositeLogin : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://thedemosite.co.uk/login.php";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var lg = new Login(driver);

            lg.login("test", "test");

            string result = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/big/blockquote/blockquote/font/center/b")).Text;

            Assert.AreEqual(result, "**Failed Login**");
        }
    }
}
