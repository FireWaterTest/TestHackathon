using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace ConsoleApplication8
{
    public class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://yazilim042/EBYS/Login.aspx";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.FindElement(By.Id("KullaniciAdi")).SendKeys("test1");
            driver.FindElement(By.Id("Sifre")).SendKeys("111");
            driver.FindElement(By.Id("login-form")).Submit();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));

            foreach (var item in driver.FindElements(By.TagName("button")))
            {
                if (item.Text == "Diğer Oturumları Kapat")
                    item.Click();
            }

        }

        [TearDown]
        public List<string> EndTest()
        {
            var listLog = new List<LogEntry>();

            foreach (var item in driver.Manage().Logs.AvailableLogTypes)
            {
                var testLogs = driver.Manage().Logs.GetLog(item);
                listLog.AddRange(testLogs);

                foreach (var log in testLogs)
                {
                    Console.WriteLine(log.Message);
                }
            }

            return listLog.Select(p => p.Message).ToList();
        }
    }
}
