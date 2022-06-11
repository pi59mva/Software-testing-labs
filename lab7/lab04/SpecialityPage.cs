using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class SpecialityPage : PageObject
    {
        public SpecialityPage(IWebDriver driver) : base(driver) { }
        public NavigationComponent NavigationComponent => new NavigationComponent(driver);

        [AllureStep("Open Speciality page")]
        public void OpenSpecialityPage()
        {
            driver.FindElement(By.CssSelector("li:nth-child(5) span:nth-child(2)")).Click();
        }


        [AllureStep("Click delete button")]
        public void ClickOnDeleteSpecialityButton()
        {
            driver.FindElement(By.CssSelector("tr:nth-child(4) .deleteSpecialty")).Click();
        }
    }
}
