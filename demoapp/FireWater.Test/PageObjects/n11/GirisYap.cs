using FireWater.Test.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace FireWater.Test.PageObjects.n11
{
    /// <summary>
    /// 
    /// </summary>
    public class GirisYap : BaseCase
    {
        public GirisYap(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }

        public AnaSayfa login(string email, string password)
        {

            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("loginButton")).Click();

            return new AnaSayfa(driver);
        }

    }
}
