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
    [TestFixture]
    public class AddUser : BaseCase
    {
       public AddUser(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }


        public IWebDriver addUser(string username, string password)
        {
            driver.Url = "http://thedemosite.co.uk/login.php";

            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.Name("FormsButton2")).Click();

            return driver;
        }

    }
}
