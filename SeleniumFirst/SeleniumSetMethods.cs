using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void Click(this IWebElement element)
        {
            element.Click();
        }

        //Drop down
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
