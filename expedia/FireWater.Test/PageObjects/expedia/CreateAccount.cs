using FireWater.Test.PageDatas;
using FireWater.Test.PageEntities.expedia;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireWater.Test.PageObjects.expedia
{
    public class CreateAccount : BaseCase
    {
        public CreateAccount(IWebDriver driver)
        {
            base.driver = driver;
            //if (driver.FindElement(By.TagName("title")).Text != "test")
            //{
            //    throw new OperationException("This is not Home Page of logged in user, current page is:");
            //}
        }


        public IWebDriver addUser(pData prms)
        {

            var dataSource = prms.dataSource.FirstOrDefault();

            foreach (Dictionary<string, object> input in prms.inputs)
            {
                foreach (Dictionary<string, object> item in input.Values)
                {
                    driver.FindElement(By.Id(item["id"].ToString())).SendKeys(dataSource[item["id"].ToString()]);
                }

            }
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            string title = (string)js.ExecuteScript("$('#create-account-expedia-policy').trigger('click')");

            driver.FindElement(By.Id("create-account-form")).Submit();

            return driver;
        }
    }
}
