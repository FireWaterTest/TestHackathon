using FireWater.Test.Common;
using FireWater.Test.PageDatas;
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

        public IWebDriver findHotel(pData prms)
        {
            var hotelSection = driver.FindElement(By.XPath("//*[@id=\"wizard-theme-wrapper\"]/ul/li[2]"));

            if (hotelSection == null)
            {
                throw new OperationException("HomePage butonu aktif değil");
            }

            hotelSection.Click();

            var dataSource = prms.dataSource.FirstOrDefault();

            foreach (Dictionary<string, object> input in prms.inputs)
            {
                foreach (Dictionary<string, object> item in input.Values)
                {
                    driver.FindElement(By.Id(item["id"].ToString())).SendKeys(dataSource[item["id"].ToString()]);
                }
            }

            driver.FindElement(By.XPath("//*[@id=\"wizard-theme-wrapper\"]/div/form")).Submit();

            return driver;
        }

    }
}
