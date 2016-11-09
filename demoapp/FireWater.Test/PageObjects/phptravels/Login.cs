using FireWater.Test.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace FireWater.Test.PageObjects.phptravels
{
    /// <summary>
    /// http://thedemosite.co.uk/login.php
    /// username: test
    /// password: test
    /// </summary>
    public class Login : BaseCase
    {
        public Login(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "Sign-on: Mercury Tours")
            //{
            //    throw new OperationException("This is not valid, current page is:" + driver.FindElement(By.TagName("title")).Text);
            //}
        }

        public IWebDriver login(string userName, string password)
        {
            driver.FindElement(By.Name("userName")).SendKeys(userName);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.Name("login")).Click();

            return driver;
        }
    }
}
