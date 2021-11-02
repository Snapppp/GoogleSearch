using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace GoogleTest.Pages
{
    class GoogleHomePage 
    {
       private readonly By searchBox = By.Name("q");
       private readonly By xPath = By.XPath("//div[@class='yuRUbf']//a/br/following-sibling::h3");
       private readonly IWebDriver driver;
       private readonly WebDriverWait wait;
       
       
        public GoogleHomePage(IWebDriver driver)
       {
            this.driver = driver;
            wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 10));
        }
        public void Open()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        public void Search(string text)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(searchBox));
            driver.FindElement(searchBox).SendKeys(text);
            driver.FindElement(searchBox).SendKeys(Keys.Return);
        }
         public string returnTItle(string text)
        {
            string text = "Facebook Log In Or Sign Up";
            return text;
        }


        public string GetFirstLinkTitle()
        {
            
            IWebElement itemText = driver.FindElement(xPath);
            string getText = itemText.Text;
            return getText;
            
            

        }
    }

 }
