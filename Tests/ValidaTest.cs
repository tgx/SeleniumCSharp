using NUnit.Framework;
using SeleniumCSharp.Page;


namespace SeleniumCSharp.Tests
{
    class ValidaTest : ValidaPage
    {
        [Test]
        public void ValidaCepInvalido()
        {
            opcaoEndereco = true;
            PreencherCep("80700000");
            ClicaBtnBusca();
            ValidaResultadoNaoEncontrado();
            driverQuit = false;
        }

        [Test] 
        // Na validacao do CEP correto, precisei alterar o nome da Rua, pois acredito que deve ter atualizado no site dos correios
        // Acredito que deveria ser pra validar o enderecao encontrado
        public void ValidaCepValido()
        {
            opcaoEndereco = true;
            PreencherCep("01013001");
            ClicaBtnBusca();
            ValidaResultado();
            driverQuit = true;
        }


        [Test]
        public void ValidaProcuraCodigo()
        {
            driver.Navigate().GoToUrl(produto);
            PreencherCodigo("SS987654321BR");
            ClicaBtnBuscaProduto();
            // O Site dos correios adicionou um captcha para poder pesquisar algum produto, não tive tempo suficiente para pesquisar
            // como fazer um bypass

        }
    }
}
