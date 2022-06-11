using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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

        public enum BrowserTypes
        {
            Chrome,
            Firefox
        }
        public BrowserTypes browserType;
        public Base(BrowserTypes browser)
        {
            browserType = browser;
        }

        [SetUp]
        public void Setup()
        {
            //driver = new ChromeDriver("driver");
            //driver.Url = BaseUrl;
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //var additionalSelenoidCapabilities = new Dictionary<string, object>();
            //additionalSelenoidCapabilities.Add("name", " test");
            //additionalSelenoidCapabilities.Add("enableVNC", true);
            //additionalSelenoidCapabilities.Add("enableVideo", true);

            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddAdditionalCapability("selenoid:options", additionalSelenoidCapabilities, true);

            //driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions.ToCapabilities());
            //driver.Url = BaseUrl;
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            ChooseBrowser(browserType);

            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.Navigate().GoToUrl(BaseUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(500);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(500);
        }

        public void ChooseBrowser(BrowserTypes browserType)
        {

            var additionalSelenoidCapabilities = new Dictionary<string, object>();
            additionalSelenoidCapabilities.Add("name", "Simple test");
            additionalSelenoidCapabilities.Add("enableVNC", true);
            additionalSelenoidCapabilities.Add("enableVideo", true);


            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    var chrome_options = new ChromeOptions();
                    chrome_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), (new ChromeOptions()).ToCapabilities());
                    break;
                case BrowserTypes.Firefox:
                    var firefox_options = new FirefoxOptions();
                    firefox_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), (new FirefoxOptions()).ToCapabilities());
                    break;
                default:
                    driver = new ChromeDriver(@"\\driver");
                    break;
            }
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

