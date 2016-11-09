using FireWater.Test.Common;
using OpenQA.Selenium;

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
    public class AnaSayfa : BaseCase
    {

        public AnaSayfa(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }
    }
}
