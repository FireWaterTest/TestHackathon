using FireWater.Test.PageObjects.phptravels;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageTests.phptravels
{
    /// <summary>
    /// http://thedemosite.co.uk/login.php
    /// username: test
    /// password: test
    /// </summary>
    public class PhptravelsCaseLogin : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://newtours.demoaut.com/mercurysignon.php";
            var login = new Login(driver);

            login.login("test", "test");

            //string result = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[1]/td/font/font/b/font/font")).Text;

            //Assert.AreEqual(result, "Flight Details");
        }
    }
}
