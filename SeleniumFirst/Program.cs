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
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&amp;Password=&amp;Login=Login");
        }

        [Test]
        public void ExecuteTest()
        {

            EAPajeObject page = new EAPajeObject();

            page.TxtInitial.SendKeys("Executeauthomation");

            page.BtnSave.Click();

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
