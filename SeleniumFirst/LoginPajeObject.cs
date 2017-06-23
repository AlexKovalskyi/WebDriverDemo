using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class LoginPajeObject
    {
        public LoginPajeObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }


        public EAPajeObject Login(string userName, string passsword)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(passsword);
            BtnLogin.Submit();

            //Return page object
            return new EAPajeObject();
        }

    }
}
