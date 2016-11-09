using FireWater.Test.PageObjects.n11;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FireWater.Test.PageTests.n11
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
    public class N11CaseAnaSayfa : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://www.n11.com/";

            var anasayfa = new AnaSayfa(driver);

            //string result = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/big/blockquote/blockquote/font/center/b")).Text;

            //Assert.AreEqual(result, "**Failed Login**");
        }
    }
}
