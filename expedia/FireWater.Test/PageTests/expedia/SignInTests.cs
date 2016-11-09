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

    class SignInTests : ICase
    {
        [Test]
        public void runTest()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://www.expedia.com/user/signin";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var usr = new SignIn(driver);
            string path = "FireWater.Test\\PageDatas\\expedia\\SignIn.json";
            var json = File.ReadAllText(path);

            var data = Extensions.toObjectFromJson<pData>(json);


            usr.signIn(data);

            var testElement = driver.FindElement(By.XPath("//*[@id=\"header-account-menu\"]"));

            string result = string.Empty;
            if (testElement != null)
                result = testElement.Text;

            Assert.AreNotEqual(result, "Account");
        }

    }
}
