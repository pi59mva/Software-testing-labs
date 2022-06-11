using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class PetPage : PageObject
    {
        
        public PetPage(IWebDriver driver) : base(driver) { }

        public NavigationComponent NavigationComponent => new NavigationComponent(driver);

        [AllureStep("Opens pet types page")]
        public void OpenPetPage()
        {
            driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
        }
        [AllureStep("Clicking edit button)")]
        public void ClickOnEditPetButton()
        {
            driver.FindElement(By.CssSelector("tr:nth-child(2) .editPet")).Click();
        }

        [AllureStep("Clicking update button)")]
        public void ClickOnUpdatePetButton()
        {
            driver.FindElement(By.CssSelector(".updatePetType")).Click();
        }

        [AllureStep("Change name")]
        public void ChangeNameValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("name"), value, overwrite);
        }

        [AllureStep("Check if update button disabled")]
        public bool isUpdateButtonDisabled()
        {

            return !driver.FindElement(By.CssSelector(".updatePetType")).Enabled;

        }

        public void ClickOnSaveNewPetButton()
        {
             driver.FindElement(By.CssSelector(".btn .saveType")).Click();
        }
    }
}
