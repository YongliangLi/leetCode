using OpenQA.Selenium.Support.PageObjects;

namespace LeetCodeFramework
{
    public class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }
    }
}
