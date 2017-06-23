using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]
        public void ExecuteTest()
        {
            //Login to app
            LoginPajeObject pageLogin = new LoginPajeObject();
            EAPajeObject pageEA =  pageLogin.Login("execute", "automation");
            pageEA.FillUserForm("KK", "Kartrick", "Authomation");




            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropType.Id);

            //SeleniumSetMethods.EnterText("Initial", "execute", PropType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropType.Id));
            //Console.WriteLine("The value from my Initial is:"+ SeleniumGetMethods.GetText("Initial", PropType.Name));

            //SeleniumSetMethods.Click("Save", PropType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Close();
        }
    }
}
