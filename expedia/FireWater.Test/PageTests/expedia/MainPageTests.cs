using FireWater.Test.PageDatas;
using FireWater.Test.PageObjects.expedia;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageTests.expedia
{
    [TestFixture]

    public class MainPageTests : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();

            driver.Url = "https://www.expedia.com/";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            var usr = new MainPage(driver);
            string path = "FireWater.Test\\PageDatas\\expedia\\MainPage_FindHotel.json";
            var json = File.ReadAllText(path);

            var data = Extensions.toObjectFromJson<pData>(json);

            usr.findHotel(data);

            var testElement = driver.FindElement(By.XPath("//*[@id=\"resultsContainer\"]/section/article[1]"));

            string result = string.Empty;
            if (testElement != null)
                result = testElement.Text;

            Assert.AreNotEqual(result, "Account");

            driver.Close();
        }
    }
}
