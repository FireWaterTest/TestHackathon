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
    [TestFixture]
    public class ThedemositeCaseAddUser : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://newtours.demoaut.com/mercurysignon.php";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var usr = new AddUser(driver);

            usr.addUser("test", "test");

            string result = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/big/blockquote/blockquote/font/center/b")).Text;

            Assert.AreEqual(result, "**Failed Login**");

        }

    }
}
