using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotmartTest.Page
{
    public class LoginPage
    {
        public BrowserSession _browser;

        public LoginPage(BrowserSession browser) {
            _browser = browser;
        }

        public LoginPage()  {     }

        public void acessar() {
            _browser.Visit("https://www.instagram.com/");
        }

        public void campoEmail( string email) {
            _browser.FillIn("username").With(email);
        }

        public void campoSenha(string pass) {
            _browser.FillIn("password").With(pass);
        }

        public void botaoEntrar() {
            _browser.FindXPath("//div[@class='            qF0y9          Igw0E     IwRSH      eGOV_         _4EzTm                                                                                                              ' ]").Click();
        }
    }
}
