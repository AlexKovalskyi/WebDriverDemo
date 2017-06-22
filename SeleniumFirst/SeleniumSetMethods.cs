using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public class SeleniumSetMethods
    {
        public static void EnterText(string element, string value, PropType elementType)
        {
            if (elementType == PropType.Id)
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == PropType.Name)
            {
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        public static void Click(string element, PropType elementType)
        {
            if (elementType == PropType.Id)
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == PropType.Name)
            {
                PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
            }
        }

        //Drop down
        public static void SelectDropDown(string element, string value, PropType elementType)
        {

            if (elementType == PropType.Id)
            {
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementType == PropType.Name)
            {
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}
