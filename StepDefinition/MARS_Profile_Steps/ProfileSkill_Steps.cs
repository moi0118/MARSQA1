using System;
using MarsQA1.Utilities;
using MARSQA1.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MARSQA1
{
    [Binding]
    public class ProfileSkill_Steps : Driver
    {
        Profile profile = new Profile();


        [Given(@"\[Seller is able to login on MARS Profile Skill Page\.]")]
        public void GivenSellerIsAbleToLoginOnMARSProfileSkillPage_()
        {
            driver = new ChromeDriver();

            Login logIn = new Login();
            logIn.LoginSteps(driver);
        }


        [When(@"\[Creating a new '([^']*)' and '([^']*)' Entry]")]
        public void WhenCreatingANewAndEntry(string Skill, string SkillLevel)
        {
            profile.CreateSkill(driver, Skill, SkillLevel);
        }

        [Then(@"\[the new '([^']*)' and '([^']*)' Entry should be added successfully\.]")]
        public void ThenTheNewAndEntryShouldBeAddedSuccessfully_(string Skill, string SkillLevel)
        {
           
            string skill = profile.GetSkill(driver);
            string skillLvl = profile.GetSkillLvl(driver);

            Assert.That(skill == Skill, "Actual record and Skill expected record do not match.");
            Assert.That(skillLvl == SkillLevel, "Actual record and Skill Level expected record do not match.");
        }



        [When(@"\[Updating a '([^']*)' and '([^']*)' Entry\.]")]
        public void WhenUpdatingAAndEntry_(string Skill, string SkillLevel)
        {
            profile.UpdateSkill(driver, Skill, SkillLevel);
        }

        [Then(@"\[the '([^']*)' and '([^']*)' Entry should be updated successfully\.]")]
        public void ThenTheAndEntryShouldBeUpdatedSuccessfully_(string Skill, string SkillLevel)
        {

            string UpdatedSkill = profile.GetUpdateSkill(driver);
            string UpdatedSkillLvl = profile.GetUpdateSkillLvl(driver);
            Assert.That(UpdatedSkill == Skill, "Actual record and Language expected record do not match.");
            Assert.That(UpdatedSkillLvl == SkillLevel, "Actual record and Language Level expected record do not match.");

        }



        [When(@"\[Deleting a Skill Entry\.]")]
        public void WhenDeletingASkillEntry_()
        {
            profile.DeleteSkill(driver);
        }

        [Then(@"\[the Skill Entry should be deleted\.]")]
        public void ThenTheSkillEntryShouldBeDeleted_()
        {
            string SkillAfterDelete = profile.GetLangAfterDelete(driver);

            if (profile.Skill != SkillAfterDelete)
            {

                Assert.Pass("Skill successfully deleted");
            }
            else
            {
                Assert.Fail("Skill not successfully deleted");
            }
        }


        [Then(@"\[Close the MARS Profile Skill Page\.]")]
        public void ThenCloseTheMARSProfileSkillPage_()
        {
            driver.Quit();
        }


    }
}
