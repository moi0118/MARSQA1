using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARSQA1.Pages
{
    class Login
    {
        public void LoginSteps (IWebDriver driver)

        {

            //open chrome browser
            driver.Manage().Window.Maximize();


            //launch MARSQA portal 
            driver.Navigate().GoToUrl("http://localhost:5000/");
            

            try
            {
                //click sign-in
                IWebElement signIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signIn.Click();
                Thread.Sleep(2000);
                

                //identify email address textbox and enter valid email
                IWebElement emailAdd = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailAdd.SendKeys("moises.softwaretester87@gmail.com");



                //identify the password textbox and enter valid password
                IWebElement password = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[1] / div / div[2] / input"));
                password.SendKeys("q1w2e3r4t5y6Q!");

                //click login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                Thread.Sleep(3000);
            }
            catch(Exception ex)
            {

                Assert.Fail("Login Page did not load", ex.Message);
            }


        }



    }
}
