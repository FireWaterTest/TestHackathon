using FireWater.Test.PageObjects.n11;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageTests.n11
{
    /// <summary>
    /// n11.com web sitesi giris-yap sayfasi üzerinden kullanici girisi test edilecek.
    /// Eposta: vsendag3@gmail.com
    /// Sifre: 123654Fire
    /// </summary>
    public class N11CaseGirisYap : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://www.n11.com/giris-yap";

            var girisPage = new GirisYap(driver);
            girisPage.login("vsendag3@gmail.com", "123654Fire");

            //string result = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/big/blockquote/blockquote/font/center/b")).Text;

            //Assert.AreEqual(result, "**Failed Login**");
        }
    }
}
