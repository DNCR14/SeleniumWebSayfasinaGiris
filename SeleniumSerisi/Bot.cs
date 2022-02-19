using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSerisi
{
    public class Bot
    {
        IWebDriver driver;

        public void SayfayaGiris()
        {
            // Chrome driver yolu 
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:/Program Files/Google/Chrome");
            driver = new ChromeDriver(service); //driver nesnesi türetme
            driver.Navigate().GoToUrl("https:\\muhammeddincer.com"); // gidilecek sayfa
        }
    }
}
