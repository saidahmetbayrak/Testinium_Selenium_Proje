using OpenQA.Selenium;

namespace TestiniumSeleniumProje
{

public class SearchPage{

        private static IWebElement element = null;

/// <summary>
/// Arama Girişinin değeri
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
       public static IWebElement txt_Data(IWebDriver driver)
        {

            element = driver.FindElement(By.ClassName("search-box"));

            return element;

        }

/// <summary>
/// Arama kisindaki değeri gelmesini sağlamak için LinkText kullanıldı
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement btn_Search(IWebDriver driver)
        {

            element = driver.FindElement(By.LinkText("Bilgisayar"));

            return element;

        }

/// <summary>
/// Rastege seçilen ürün değeri
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement select_Item(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath("//div[@data-id= '32001713']/div[1]/a"));

            return element;

        }

/// <summary>
/// Sepette eKleme butonun değeri
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement add_Item(IWebDriver driver)
        {

            element = driver.FindElement(By.ClassName("add-to-bs-tx"));

            return element;

        }

/// <summary>
/// Sepetteki ürün adetinin artırılmasını sağlar
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement add_ItemPlus(IWebDriver driver)
        {

            element = driver.FindElement(By.ClassName("ty-numeric-counter-button"));

            return element;

        }

/// <summary>
/// Sepetteki ürünleri silme değeri
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement delete_Item(IWebDriver driver)
        {

            element = driver.FindElement(By.ClassName("i-trash"));

            return element;

        }
}

}

            