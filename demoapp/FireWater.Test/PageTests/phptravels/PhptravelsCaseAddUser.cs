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
    /// http://newtours.demoaut.com/mercuryregister.php 
    /// sayfasi üzerinden üyelik kaydi acilmasi test edilecek.
    /// Adı: FIRE
    /// Soyadı: WATER
    /// Eposta: vsendag3@gmail.com
    /// Sifre: 123654Fire
    /// Cinsiyet: Erkek
    /// </summary>
    [TestFixture]
    public class PhptravelsCaseAddUser : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://newtours.demoaut.com/mercuryregister.php";

            var addUser = new AddUser(driver);

            addUser.register("FIRE", "WATER", "vsendag3@gmail.com", "123654Fire");

            //string result = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[3]/td/p[2]/font")).Text;

            //Assert.IsNotEmpty(result);
        }

    }
}
