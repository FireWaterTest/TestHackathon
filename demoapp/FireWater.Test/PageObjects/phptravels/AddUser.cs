using FireWater.Test.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageObjects.phptravels
{
    /// http://newtours.demoaut.com/mercuryregister.php 
    /// sayfasi üzerinden üyelik kaydi acilmasi test edilecek.
    /// Adı: FIRE
    /// Soyadı: WATER
    /// Eposta: vsendag3@gmail.com
    /// Sifre: 123654Fire
    /// Cinsiyet: Erkek
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


        [Test]
        public IWebDriver register(string firstName, string lastName, string userName, string password)
        {
            
            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.Name("userName")).SendKeys(userName);
            driver.FindElement(By.Name("email")).SendKeys(userName);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.Name("confirmPassword")).SendKeys(password);
            driver.FindElement(By.Name("register")).Click();

            return driver;
        }

    }
}
