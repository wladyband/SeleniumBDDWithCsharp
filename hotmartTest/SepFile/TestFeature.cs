using hotmartTest.Common;
using hotmartTest.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace hotmartTest.SepFile
{
    [Binding]
    public  class TestFeature: BaseTeste
    {
        private LoginPage _loginPage;


        [SetUp]
        public void inicio()
        {

            _loginPage = new LoginPage(browser);
        }

        [Given(@"acesso a pagina")]
        public void GivenAcessoAPagina()
        {
            _loginPage.acessar();
        }

        [Given(@"eu como usuario digito o email")]
        public void GivenEuComoUsuarioDigitoOEmail()
        {
            _loginPage.campoEmail("usuarioqualquer");
        }

        [Given(@"eu como usuario digito a senha")]
        public void GivenEuComoUsuarioDigitoASenha()
        {
            _loginPage.campoSenha("senha auqlaque3r");
        }

        [When(@"eu como usuario clico no botao entrar")]
        public void WhenEuComoUsuarioClicoNoBotaoEntrar()
        {
            _loginPage.botaoEntrar();
        }

        [Then(@"mostra a mensagem de confirmacao")]
        public void ThenMostraAMensagemDeConfirmacao()
        {
            var mensagem = browser.FindXPath("//div[@class='olLwo']");
            Assert.AreEqual("Salvar suas informações de login?", mensagem.Text);
        }

    }
}
