using NUnit.Allure.Attributes;
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

        [AllureStep("Opens add new owner page")]
        public void OpenAddNewOwnerPage()
        {
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)")).Click();
        }
        [AllureStep("Opens  owner page")]
        public void OpenOwnerPage()
        {
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
        }
        [AllureStep("Change First Name")]
        public void ChangeFirstNameValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("firstName"), value, overwrite);
        }
        [AllureStep("OChange Last Name")]
        public void ChangeLastNameValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("lastName"), value, overwrite);
        }
        [AllureStep("Change Adress")]
        public void ChangeAddressValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("address"), value, overwrite);
        }

        [AllureStep("Change City")]
        public void ChangeCityValue(string value, bool overwrite = true)
        { 
            ChangeInputValue(By.Id("city"), value, overwrite);
        }
        [AllureStep("Change Telephone")]
        public void ChangeTelephoneValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("telephone"), value, overwrite);
        }

        [AllureStep("Clicking Create Button")]
        public void ClickOnCreateButton() 
        {
            driver.FindElement(By.CssSelector(".addOwner")).Click();
        }
        [AllureStep("Clicking Update Button")]
        public void ClickOnUpdateButton()
        {
            driver.FindElement(By.CssSelector(".updateOwner")).Click();
        }
    }
}
