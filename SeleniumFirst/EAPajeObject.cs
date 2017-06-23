using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class EAPajeObject
    {
        public EAPajeObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DdlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement TxtMiddleName { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName)
        {
            TxtInitial.EnterText(initial);
            TxtFirstName.EnterText(firstName);
            TxtMiddleName.EnterText(middleName);
            BtnSave.Click();

            SeleniumSetMethods.EnterText(TxtInitial, initial);
            SeleniumSetMethods.EnterText(TxtFirstName, firstName);
            SeleniumSetMethods.EnterText(TxtMiddleName, middleName);
            SeleniumSetMethods.Click(BtnSave);

            //TxtInitial.SendKeys(initial);
            //TxtFirstName.SendKeys(firstName);
            //TxtMiddleName.SendKeys(middleName);
            //BtnSave.Click();
        }

    }
}
