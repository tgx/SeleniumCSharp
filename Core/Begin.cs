using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace SeleniumCSharp.Core
{
    public class Begin : Variables
    {
        [SetUp]
        public void InicioTeste()
        {
  
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(endereco);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Flag para manter o browser aberto
            driverQuit = false;
        }


        // no teardown, coloquei a condigao para verificar, caso deseje fechar o browser
        [TearDown] public void Teardown() {if(driverQuit) driver.Quit(); }
    }
}
