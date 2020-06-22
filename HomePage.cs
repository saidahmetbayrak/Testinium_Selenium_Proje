using OpenQA.Selenium;

namespace TestiniumSeleniumProje
{

public class HomePage{

        private static IWebElement element = null;
/// <summary>
/// Gİriş Butonun Id Değeri
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement btn_LogIn(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("accountBtn"));

            return element;
        }
/// <summary>
/// Sepet iconu tıklama olayı
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
         public static IWebElement btn_Basket(IWebDriver driver)
        {
            element =  driver.FindElement(By.ClassName("icon-container"));

            return element;
        }
/// <summary>
/// Acilan Popup Giriş yap ekranın Kapatma Olayı
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
            public static IWebElement close_Popup(IWebDriver driver)
        {
            element =  driver.FindElement(By.ClassName("fancybox-item fancybox-close"));

            return element;
        }
}

}

