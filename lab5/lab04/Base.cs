using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public  class Base
    {
        public static IWebDriver driver;
        public static string BaseUrl = "https://client.sana-commerce.dev/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("driver");
            driver.Url = BaseUrl;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

