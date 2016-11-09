using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(NUnitTest));


        static void Main(string[] args)
        {
            logger.Info("İşlem başlıyor.");

            var testOto = new NUnitTest();
            logger.Info("Nesne yaratıldı."); 

            testOto.Initialize();
            logger.Info("Nesne yüklendi."); 

            testOto.OpenAppTest();
            logger.Info("Test yapıldı."); 

            testOto.EndTest();
            logger.Info("Test sonlandı."); 

        }
    }
}
