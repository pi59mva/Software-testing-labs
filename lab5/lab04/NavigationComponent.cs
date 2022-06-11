using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class NavigationComponent
    {

        private IWebDriver driver;

        public NavigationComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement OwnerTab()
        {
            return driver.FindElement(By.CssSelector(".ownerTab"));
        }

        public IWebElement AddNewOwnerTab()
        {
            return driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));
        }

       
        public void OpenAddNewOwnerTab()
        {
            this.OwnerTab().Click();

            this.AddNewOwnerTab().Click();

        }


        public IWebElement PetTab()
        {
            return driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)"));
        }

        public void OpenPetTab()
        {
            this.PetTab().Click();
        }


        public IWebElement SpecialityTab()
        {
            return driver.FindElement(By.CssSelector("li:nth-child(5) span:nth-child(2)"));
        }

        public void OpenSpecialityTab()
        {
            this.SpecialityTab().Click();
        }
    }
}
