using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LeetCodeFramework
{
    public class HomePage
    {
        static string Url = "http://www.leetcode.com";

        [FindsBy(How=How.ClassName, Using = "btn sign-in-btn")]
        private IWebElement signIn;

        public void GoTo()
        {
            Browser.Goto(Url);
        }

        public void SignIn()
        {
            // Method intentionally left empty.
        }


    }
}
