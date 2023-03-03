using NUnit.Framework;
using OpenQA.Selenium;


namespace SeleniumCSharp.Core
{
    public class Suite : Begin
    {
        public void EscreverTexto(string path, string valor)
        {
            driver.FindElement(By.XPath(path)).SendKeys(valor);
        }

        public void ClicarBotao(string path) 
        {
            String name = driver.FindElement(By.XPath(path)).Text;
            Assert.That(driver.FindElement(By.XPath(path)).Text, Is.EqualTo(name));
            driver.FindElement(By.XPath(path)).Click();
        }


        public void validarDados(string path, string valor)
        {
            Assert.That(driver.FindElement(By.XPath(path)).Text, Does.Contain(valor));

        }
    }
}
