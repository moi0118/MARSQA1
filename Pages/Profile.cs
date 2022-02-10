using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MARSQA1.Pages
{
    class Profile
    {
        public string Description;
        public string Language;
        public string Skill;


        public void CreateDescription(IWebDriver driver)
        {

            IWebElement CreateDescBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            CreateDescBtn.Click();

            IWebElement TextArea = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            TextArea.Click();
            TextArea.Clear();
            TextArea.SendKeys("Test description one.");
            Description = TextArea.Text;

            IWebElement SaveBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            SaveBtn.Click();
        }

        public string GetDescription(IWebDriver driver)
        {
            Thread.Sleep(2000);                                     
            IWebElement GetDesc = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return GetDesc.Text;
        }


        public void EditDescription(IWebDriver driver)
        {

            IWebElement EditDescBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            EditDescBtn.Click();

            IWebElement TextArea = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            TextArea.Click();
            TextArea.Clear();
            TextArea.SendKeys("Test edited description one.");
            Description = TextArea.Text;

            IWebElement SaveBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            SaveBtn.Click();
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement GetDesc = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return GetDesc.Text;
        }


        public void DeleteDescription(IWebDriver driver)
        {
            IWebElement EditDescBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            EditDescBtn.Click();

            IWebElement TextArea = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            TextArea.Click();
            TextArea.Clear();
            TextArea.SendKeys(" ");
            TextArea.Clear();

            IWebElement SaveBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            SaveBtn.Click();
        }


        public void CreateLanguage(IWebDriver driver, string LanguagePrm, string LanguageLevelPrm)
        {
            IWebElement LanguageTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageTab.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewBtn.Click();

            IWebElement LanguageTxtBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            LanguageTxtBox.SendKeys(LanguagePrm);


            IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            LanguageLevel.SendKeys(LanguageLevelPrm);

            IWebElement AddBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddBtn.Click();

        }

        public string GetLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement GetLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return GetLanguage.Text;
        }

        public string GetLangLvl(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement GetLangLvl = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return GetLangLvl.Text;
        }


        public void UpdateLanguage(IWebDriver driver, string LanguagePrm, string LanguageLevelPrm)
        {
            IWebElement LanguageTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageTab.Click();

            IWebElement EditBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            EditBtn.Click();


            IWebElement Language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            Language.Click();
            Language.Clear();
            Language.SendKeys(LanguagePrm);

          
            IWebElement LanguageLvl = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            LanguageLvl.SendKeys(LanguageLevelPrm);



            IWebElement UpdateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateBtn.Click();
        }

        public string GetUpdateLanguage(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement GetUpdatedLang = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return GetUpdatedLang.Text;
        }

        public string GetUpdateLanguageLvl(IWebDriver driver)
        {
            Thread.Sleep(1000);
                                                                      
            IWebElement GetUpdatedLang = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return GetUpdatedLang.Text;
        }

        public void DeleteLanguage(IWebDriver driver)
        {
            IWebElement LangBeforeDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Language = LangBeforeDelete.Text;
           
            IWebElement DeleteBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            DeleteBtn.Click();
        }

        public string GetLangAfterDelete(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement LangAfterDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return LangAfterDelete.Text;
        }

        public void CreateSkill(IWebDriver driver, string Skill, string SkillLevel)
        {

            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewBtn.Click();

            IWebElement SkillTxtBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            SkillTxtBox.SendKeys(Skill);


            IWebElement SkillLvl = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillLvl.SendKeys(SkillLevel);

            IWebElement AddBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddBtn.Click();

        }

        public string GetSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement GetSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return GetSkill.Text;
        }

        public string GetSkillLvl(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement GetSkillLvl = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return GetSkillLvl.Text;
        }



     

        public void UpdateSkill(IWebDriver driver, string Skill, string SkillLevel)
        {
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();

            IWebElement EditBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            EditBtn.Click();

            IWebElement skill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            skill.Click();
            skill.Clear();
            skill.SendKeys(Skill);

            IWebElement skillLvl = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            skillLvl.SendKeys(SkillLevel);

            IWebElement UpdateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            UpdateBtn.Click();
        }

        public string GetUpdateSkill(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement GetUpdatedSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return GetUpdatedSkill.Text;
        }

        public string GetUpdateSkillLvl(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement GetUpdatedSkillLvl = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return GetUpdatedSkillLvl.Text;
        }

        public void DeleteSkill(IWebDriver driver)
        {

            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();

            IWebElement SkillBeforeDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            Skill = SkillBeforeDelete.Text;

            IWebElement DeleteBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            DeleteBtn.Click();
        }

        public string GetSkillAfterDelete(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement SkillAfterDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return SkillAfterDelete.Text;
        }











    }
}
