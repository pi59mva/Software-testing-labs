using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class TestCases : Base
    {
        [Test, Description("This test checks entering long value in updating pet types")]
        [AllureSuite("Pet")]
        public void TestCase7() 
        {
            //var po = new PetPage(driver);
            //po.OpenPetPage();
            //po.ClickOnEditPetButton();
            //po.ChangeNameValue("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq", true);
            //po.ClickOnUpdatePetButton();
            //Assert.True(po.isUpdateButtonDisabled());

            Pages.PetPage.NavigationComponent.OpenPetTab();
            Pages.PetPage.ClickOnEditPetButton();
            Pages.PetPage.ChangeNameValue("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
            Pages.PetPage.ClickOnUpdatePetButton();
            Assert.True(Pages.PetPage.isUpdateButtonDisabled());

        }


        [Test, Description("This test checks that speciality could be deleted succesfully")]
        [AllureSuite("Speciality")]
        public void TestCase10()
        {
            //var po = new SpecialityPage(driver);
            //po.OpenSpecialityPage();
            //po.ClickOnDeleteSpecialityButton();

            Pages.SpecialityPage.NavigationComponent.OpenSpecialityTab();
            Pages.SpecialityPage.ClickOnDeleteSpecialityButton();
        }


        [Test, Description("This test checks that owner could be created succesfully")]
        [AllureSuite("Owner")]
        public void TestCase1()
        {

            //var po = new OwnerPage(driver);
            //po.OpenAddNewOwnerPage();
            //po.ChangeFirstNameValue("qweqwe");
            //po.ChangeLastNameValue("qwelastname");
            //po.ChangeAddressValue("qweaddress");
            //po.ChangeCityValue("qwecity");
            //po.ChangeTelephoneValue("1715175175");
            //po.ClickOnCreateButton();

            Pages.OwnerPage.NavigationComponent.OpenAddNewOwnerTab();
            Pages.OwnerPage.OpenAddNewOwnerPage();
            Pages.OwnerPage.ChangeFirstNameValue("qweqwe");
            Pages.OwnerPage.ChangeLastNameValue("qwelastname");
            Pages.OwnerPage.ChangeAddressValue("qweaddress");
            Pages.OwnerPage.ChangeCityValue("qwecity");
            Pages.OwnerPage.ChangeTelephoneValue("1715175175");
            Pages.OwnerPage.ClickOnCreateButton();
        }
    }
}
