using FireWater.Test.PageDatas;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageObjects.expedia
{
    public class SignIn : BaseCase
    {
        public SignIn(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }


        public IWebDriver signIn(pData prms)
        {

            var dataSource = prms.dataSource.FirstOrDefault();

            foreach (Dictionary<string, object> input in prms.inputs)
            {
                foreach (Dictionary<string, object> item in input.Values)
                {
                    driver.FindElement(By.Id(item["id"].ToString())).SendKeys(dataSource[item["id"].ToString()]);
                }

            }

            driver.FindElement(By.Id("submitButton")).Submit();

            return driver;
        }
    }
}
