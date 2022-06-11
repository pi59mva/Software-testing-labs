using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
            //driver = new ChromeDriver("driver");
            //driver.Url = BaseUrl;
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var additionalSelenoidCapabilities = new Dictionary<string, object>();
            additionalSelenoidCapabilities.Add("name", " test");
            additionalSelenoidCapabilities.Add("enableVNC", true);
            additionalSelenoidCapabilities.Add("enableVideo", true);

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddAdditionalCapability("selenoid:options", additionalSelenoidCapabilities, true);

            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions.ToCapabilities());
            driver.Url = BaseUrl;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
                var path = $"C:\\TestResults\\{filename}";
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
            }
            driver.Quit();
        }
    }
}

