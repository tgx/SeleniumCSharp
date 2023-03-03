using OpenQA.Selenium;


namespace SeleniumCSharp.Core
{
    public class Variables
    {

        public IWebDriver driver;

        public string endereco = "https://buscacepinter.correios.com.br/app/endereco/index.php";
        public string produto = "https://rastreamento.correios.com.br/app/index.php";
        public bool opcaoEndereco;
        public bool driverQuit = true;
    }


}
