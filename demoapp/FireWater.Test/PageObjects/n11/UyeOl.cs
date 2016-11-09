using FireWater.Test.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace FireWater.Test.PageObjects.n11
{
    /// <summary>
    /// n11.com web sitesi uye-ol sayfasi üzerinden üyelik kaydi acilmasi test edilecek.
    /// Adı: FIRE
    /// Soyadı: WATER
    /// Eposta: vsendag3@gmail.com
    /// Sifre: 123654Fire
    /// Cinsiyet: Erkek
    /// 
    /// </summary>
    public class UyeOl : BaseCase
    {

        public UyeOl(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }

        public IWebDriver register(string firstName, string lastName, string registrationEmail, string registrationPassword)
        {
            
            driver.FindElement(By.Id("firstName")).SendKeys(firstName);
            driver.FindElement(By.Id("lastName")).SendKeys(lastName);
            driver.FindElement(By.Id("registrationEmail")).SendKeys(registrationEmail);
            driver.FindElement(By.Id("registrationPassword")).SendKeys(registrationPassword);
            driver.FindElement(By.Id("passwordAgain")).SendKeys(registrationPassword);
            driver.FindElement(By.Id("genderMale")).Click();
            driver.FindElement(By.Id("acceptContract")).Click();
            driver.FindElement(By.Id("submitButton")).Click();

            return driver;
        }

    }
}
