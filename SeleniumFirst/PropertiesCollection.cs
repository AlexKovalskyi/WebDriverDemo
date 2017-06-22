using OpenQA.Selenium;

namespace SeleniumFirst
{

    public enum PropType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    public class PropertiesCollection
    {
        public static IWebDriver Driver{ get; set; }
    }
}
