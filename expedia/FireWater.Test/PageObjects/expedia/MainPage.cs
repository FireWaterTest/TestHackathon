using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageObjects.expedia
{
    public class MainPage : BaseCase
    {
        public MainPage(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }


        public IWebDriver addUser(string username, string password)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.Name("FormsButton2")).Click();

            return driver;
        }

    }
}
