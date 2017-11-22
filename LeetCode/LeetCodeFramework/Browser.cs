using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LeetCodeFramework
{    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver(@"D:\Tools\chromedriver_win32");

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}