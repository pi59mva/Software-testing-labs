using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class PageObject
    {

        protected IWebDriver driver;

        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ChangeInputValue(By input, string value, bool overwrite)
        {
            var element = driver.FindElement(input);
            if (overwrite)
                element.Clear();

            element.SendKeys(value);
        }
    }
}
