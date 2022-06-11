using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class OwnerPage : PageObject
    {
        public OwnerPage(IWebDriver driver) : base(driver) { }
        public NavigationComponent NavigationComponent => new NavigationComponent(driver);
        public void OpenAddNewOwnerPage()
        {
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)")).Click();
        }

        public void OpenOwnerPage()
        {
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
        }

        public void ChangeFirstNameValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("firstName"), value, overwrite);
        }

        public void ChangeLastNameValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("lastName"), value, overwrite);
        }

        public void ChangeAddressValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("address"), value, overwrite);
        }

        public void ChangeCityValue(string value, bool overwrite = true)
        { 
            ChangeInputValue(By.Id("city"), value, overwrite);
        }

        public void ChangeTelephoneValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("telephone"), value, overwrite);
        }

        public void ClickOnCreateButton() 
        {
            driver.FindElement(By.CssSelector(".addOwner")).Click();
        }

        public void ClickOnUpdateButton()
        {
            driver.FindElement(By.CssSelector(".updateOwner")).Click();
        }
    }
}
