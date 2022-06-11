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

        public void OpenPetPage()
        {
            driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
        }

        public void ClickOnEditPetButton()
        {
            driver.FindElement(By.CssSelector("tr:nth-child(2) .editPet")).Click();
        }

        public void ClickOnUpdatePetButton()
        {
            driver.FindElement(By.CssSelector(".updatePetType")).Click();
        }

        public void ChangeNameValue(string value, bool overwrite = true)
        {
            ChangeInputValue(By.Id("name"), value, overwrite);
        }

        public bool isUpdateButtonDisabled()
        {

            return !driver.FindElement(By.CssSelector(".updatePetType")).Enabled;

        }
    }
}
