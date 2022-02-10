using MarsQA1.Utilities;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using MARSQA1.Pages;
using NUnit.Framework;
using System;
using OpenQA.Selenium;

namespace MarsQA1.Steps 
{
    [Binding]
    public class ProfileDescription_Steps : Driver
    {
        Profile profile = new Profile();

        [Given(@"\[Seller is able to login on MARS Profile Page\.]")]
        public void GivenSellerIsAbleToLoginOnMARSProfilePage_()
        {
            driver = new ChromeDriver();

            Login logIn = new Login();
            logIn.LoginSteps(driver);
        }

        [When(@"\[Creating a new Description Entry\.]")]
        public void WhenCreatingANewDescriptionEntry_()
        {
            Console.WriteLine("test");
            profile.CreateDescription(driver);
        }

        [Then(@"\[the new Description Entry should be added successfully\.]")]
        public void ThenTheNewDescriptionEntryShouldBeAddedSuccessfully_()
        {
            string description = profile.GetDescription(driver);
            Assert.That(description == profile.Description, "Actual record and Description expected record do not match.");
        }

       

        [When(@"\[Updating a Description Entry\.]")]
        public void WhenUpdatingADescriptionEntry_()
        {
            profile.EditDescription(driver);
        }

        [Then(@"\[the Description Entry should be updated successfully\.]")]
        public void ThenTheDescriptionEntryShouldBeUpdatedSuccessfully_()
        {
            string editedDescription = profile.GetEditedDescription(driver);
            Assert.That(editedDescription == profile.Description, "Actual record and Description expected record do not match.");

        }

        [When(@"\[Deleting a Description Entry\.]")]
        public void WhenDeletingADescriptionEntry_()
        {
            profile.DeleteDescription(driver);
        }

        [Then(@"\[the Description Entry should not be deleted\.]")]
        public void ThenTheDescriptionEntryShouldNotBeDeleted_()
        {
            IWebElement DeleteEntry = driver.FindElement(By.XPath("/html/body/div[1]"));

            if (DeleteEntry.Text != "")
            {
                Assert.Pass("Seller not able to delete description");
            }
            else
            {
                Assert.Fail("Seller is able to delete description");
            }
        }

        [Then(@"\[Close the browser\.]")]
        public void ThenCloseTheBrowser_()
        {
            driver.Quit();
        }


    }
}
