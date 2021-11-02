using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using GoogleTest.Pages;

namespace GoogleTest
{
    /**private readonly By searchBox = By.Name("q");
    private readonly IWebDriver driver;
    private readonly WebDriverWait wait;
    **/

    public class ParallelTest : Base
    {
        private readonly GoogleHomePage googleHomePage;

        public ParallelTest(string browserName) : base(browserName)
        {
            googleHomePage = new(driver);
            driver.Manage().Window.Maximize();
        }


        [Test, Category("google_search")]
        public void SearchGoogle()
        {    
            /**  By searchBox = By.Name("q");
                 driver.Navigate().GoToUrl("https://www.google.com/");
                 wait.Until(ExpectedConditions.ElementToBeClickable(searchBox));
                 driver.FindElement(searchBox).SendKeys("Snap");
                 driver.FindElement(searchBox).SendKeys(Keys.Return); **/

            googleHomePage.Open();
            googleHomePage.Search("Facebook");
            Assert.AreEqual(googleHomePage.GetFirstLinkTitle(),title);

        }
    }
}
