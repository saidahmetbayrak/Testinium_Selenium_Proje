using OpenQA.Selenium;


namespace TestiniumSeleniumProje
{

public class LoginPage{

        private static IWebElement element = null;

/// <summary>
/// Giriş Ekranindaki mail değernin alinmasi
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement txt_UserName(IWebDriver driver)
        {

            element = driver.FindElement(By.Id("email"));

            return element;

        }

/// <summary>
/// Giriş Ekranindaki şifre değernin alinmasi
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement txt_Password(IWebDriver driver)
        {

            element = driver.FindElement(By.Id("password"));

            return element;

        }

/// <summary>
/// Giriş Ekranindaki logini sağlayan button değeri
/// </summary>
/// <param name="driver"></param>
/// <returns></returns>
        public static IWebElement btn_SignIn(IWebDriver driver)
        {

            element = driver.FindElement(By.Id("loginSubmit"));

            return element;

        }

}

}

