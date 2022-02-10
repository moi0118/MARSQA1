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
    public class ProfileLanguage_Steps : Driver
    {
        Profile profile = new Profile();

        [Given(@"\[Seller is able to login on MARS Profile Page]")]
        public void GivenSellerIsAbleToLoginOnMARSProfilePage()
        {
            driver = new ChromeDriver();

            Login logIn = new Login();
            logIn.LoginSteps(driver);
        }


        [When(@"\[Creating a new '([^']*)' and '([^']*)' Entry\.]")]
        public void WhenCreatingANewAndEntry_(string Language, string LanguageLevel)
        {
            profile.CreateLanguage(driver, Language, LanguageLevel);
        }

        [Then(@"\[the new new '([^']*)' and '([^']*)' Entry\.]")]
        public void ThenTheNewNewAndEntry_(string Language, string LanguageLevel)
        {
            string language = profile.GetLanguage(driver);
            string langLvl = profile.GetLangLvl(driver);

            Assert.That(language == Language, "Actual record and Language expected record do not match.");
            Assert.That(langLvl == LanguageLevel, "Actual record and Language Level expected record do not match.");

        }

        /*

        [When(@"\[Updating a Language Entry\.]")]
        public void WhenUpdatingALanguageEntry_()
        {
            profile.UpdateLanguage(driver);
        }

        [Then(@"\[the Language Entry should be updated successfully\.]")]
        public void ThenTheLanguageEntryShouldBeUpdatedSuccessfully_()
        {
            string UpdatedLanguageLvl = profile.GetUpdateLanguage(driver);
            Assert.That(UpdatedLanguageLvl == "Fluent", "Actual record and Language Level expected record do not match.");

        } */


        [When(@"\[Updating a '([^']*)' and '([^']*)'\.]")]
        public void WhenUpdatingAAnd_(string Language, string LanguageLevel)
        {
            profile.UpdateLanguage(driver, Language, LanguageLevel);
        }

        [Then(@"\[the '([^']*)' and '([^']*)' should be updated successfully\.]")]
        public void ThenTheAndShouldBeUpdatedSuccessfully_(string Language, string LanguageLevel)
        {
            string UpdatedLanguage = profile.GetUpdateLanguage(driver);
            string UpdatedLanguageLvl = profile.GetUpdateLanguageLvl(driver);
            Assert.That(UpdatedLanguageLvl == LanguageLevel, "Actual record and Language expected record do not match.");
            Assert.That(UpdatedLanguageLvl == LanguageLevel, "Actual record and Language Level expected record do not match.");
        }



        [When(@"\[Deleting a Language Entry\.]")]
        public void WhenDeletingALanguageEntry_()
        {
            profile.DeleteLanguage(driver);
        }

        [Then(@"\[the Language Entry should be deleted\.]")]
        public void ThenTheLanguageEntryShouldBeDeleted_()
        {
            string LangAfterDelete = profile.GetLangAfterDelete(driver);

            if (profile.Language != LangAfterDelete)
            {

                Assert.Pass("Language successfully deleted");
            }
            else
            {
                Assert.Fail("Language not successfully deleted");
            }
        }



        [Then(@"\[Close the browser]")]
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
        }




    }
}
