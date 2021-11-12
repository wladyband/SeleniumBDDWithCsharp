using Coypu;
using Coypu.Drivers.Selenium;
using hotmartTest.Common;
using hotmartTest.Page;
using NUnit.Framework;
using System;
using System.Threading;

namespace hotmartTest.Teste
{
    public class Login: BaseTeste
    {


        private LoginPage _loginPage;

        [SetUp]
        public void inicio()
        {
         
            _loginPage = new LoginPage(browser);
        }


        [Test]
        public void SucessfullyLogin()
        {
           

            _loginPage.acessar();
            _loginPage.campoEmail("jcnejn");
            _loginPage.campoSenha("jdnvckdfv");
            _loginPage.botaoEntrar();

            var mensagem = browser.FindXPath("//div[@class='olLwo']");
            Assert.AreEqual("Salvar suas informações de login?", mensagem.Text);



        }
    }
}