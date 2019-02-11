using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_2.Utilities;

namespace Training_2.Page_Objects
{
    class Registrationpage
    {
        public Registrationpage()
        {
            PageFactory.InitElements(Hooks.Drive, this);
        }

        [FindsBy(How = How. LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.LinkText, Using = "first_name")]
        private IWebElement firstName { get; set; }


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "signup")]


        public void ClickOnRegister()
        {
            register.Click();
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("Modupe");
        }

        public void EnterEmailAddress(string myEmail)
        {
            emailAddress.SendKeys(myEmail);


        }
    }
}
