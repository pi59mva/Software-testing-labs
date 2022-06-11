using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class TestCases : Base
    {
        public TestCases() : base(BrowserTypes.Chrome) { }

        static object[] TestData = { "testdata1", "testdata2", "testdata3", "testdata4", "testdata5" };


        [Test, Description("This test checks entering long value in updating pet types")]
        [AllureSuite("Pet")]
        [Parallelizable]
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
        [Parallelizable]
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
        [TestCaseSource(nameof(TestData))]
        [Parallelizable]
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

        [Test, Description("This test trying to add pet type")]
        [TestCaseSource(typeof(TestDataCLass), nameof(TestDataCLass.TestCases1))]
        [AllureSuite("Pet")]
        [Parallelizable]
        public void TestCase5(string name)
        {
            Pages.PetPage.NavigationComponent.OpenPetTab();
            Pages.PetPage.NavigationComponent.OpenAddPetTab();
            Pages.PetPage.ChangeNameValue(name);
            Pages.PetPage.ClickOnSaveNewPetButton();


        }
    }

   
   
}

public class TestDataCLass
{
    public static IEnumerable TestCases1
    {
        get
        {
            yield return new TestCaseData("TestData1");
            yield return new TestCaseData("TestData2");
            yield return new TestCaseData("TestData3");
            yield return new TestCaseData("TestData4");
        }
    }
}

