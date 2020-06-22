using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestiniumSeleniumProje
{
  public class Program
    {
        private static IWebDriver driver = null;

        static void Main(string[] args)
        {
            
            driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();

            string link = @"https://www.trendyol.com/butik/liste";
           
            driver.Navigate().GoToUrl(link);

            
            #region LoginKısmı

            HomePage.btn_LogIn(driver).Click();

            LoginPage.txt_UserName(driver).SendKeys("MailAdresi");

            LoginPage.txt_Password(driver).SendKeys("Sifre");

            LoginPage.btn_SignIn(driver).Click();

            #endregion
            
            #region AramaKısmı

            SearchPage.txt_Data(driver).SendKeys("Bilgisayar");

            SearchPage.btn_Search(driver).Click();

            SearchPage.select_Item(driver).Click();//Burda proje detayında 2 sayfaya gidilmesin iştenilmektedir.
//Yalniz Trendyol sayfasında ürünler otomatik yükleniliyor

            SearchPage.add_Item(driver).Click();

            HomePage.btn_Basket(driver).Click();

            HomePage.close_Popup(driver).Click();

            SearchPage.add_ItemPlus(driver).Click();

            SearchPage.delete_Item(driver).Click();

            #endregion
 

        }
    }
}
