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
        [Test]
        public void TestCase7() 
        {
            var po = new PetPage(driver);
            po.OpenPetPage();
            po.ClickOnEditPetButton();
            po.ChangeNameValue("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq", true);
            po.ClickOnUpdatePetButton();
            Assert.True(po.isUpdateButtonDisabled());

        }


        [Test]
        public void TestCase10()
        {
            var po = new SpecialityPage(driver);
            po.OpenSpecialityPage();
            po.ClickOnDeleteSpecialityButton();
        }


        [Test]
        public void TestCase1()
        {
            var po = new OwnerPage(driver);
            po.OpenAddNewOwnerPage();
            po.ChangeFirstNameValue("qweqwe");
            po.ChangeLastNameValue("qwelastname");
            po.ChangeAddressValue("qweaddress");
            po.ChangeCityValue("qwecity");
            po.ChangeTelephoneValue("1715175175");
            po.ClickOnCreateButton();
        }
    }
}
