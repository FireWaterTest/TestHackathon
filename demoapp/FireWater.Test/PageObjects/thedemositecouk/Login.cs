using FireWater.Test.Common;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FireWater.Test.PageObjects.thedemositecouk
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
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }


        [Test]
        public IWebDriver login(string username, string password)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.Name("FormsButton2")).Click();

            return driver;
        }

    }
}
