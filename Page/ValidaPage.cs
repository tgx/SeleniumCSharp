using SeleniumCSharp.Core;

namespace SeleniumCSharp.Page
{
    internal class ValidaPage: Suite
    {
        public void PreencherCep(string cep)
        {
            EscreverTexto("//*[@id='endereco']",cep);
        }

        public void ClicaBtnBusca() 
        {
            ClicarBotao("//*[@id='btn_pesquisar']");
        }

        public void ClicaBtnBuscaProduto()
        {
            ClicarBotao("//*[@id=\"b-pesquisar\"]");
        }


        public void ValidaResultado()
        {
            validarDados("//*[@id='resultado-DNEC']/tbody/tr/td[1]", "Rua Quinze de Novembro - lado ímpar");
        }

        public void ValidaResultadoNaoEncontrado()
        {
            validarDados("//*[@id=\"mensagem-resultado-alerta\"]/h6", "Dados não encontrado" );
        }


        public void PreencherCodigo(string codigo)
        {
            EscreverTexto("//*[@id=\"objeto\"]", codigo);
            Console.WriteLine(codigo);
        }
    }
}
