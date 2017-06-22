using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class SeleniumGetMethods
    {

        public static string GetText(string element, PropType elementType)
        {
            if (elementType == PropType.Id)
            {
                return PropertiesCollection.Driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            if (elementType == PropType.Name)
            {
                return PropertiesCollection.Driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return string.Empty;
            }
        }

        public static string GetTextFromDDL(string element, PropType elementType)
        {
            if (elementType == PropType.Id)
            {
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            if (elementType == PropType.Name)
            {
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
