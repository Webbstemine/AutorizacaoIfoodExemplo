using AppIfood.VIEW;
using AppIfood.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppIfood.PRESENTER
{
    internal class MenuPresenter
    {
        private IMenu view;
        private IOAuth oauth;

        public MenuPresenter(IMenu view)
        {
            this.view = view;
        }

        public void GetAutorization()
        {
            oauth = new OAuth();
            oauth.GetToken();
        }

    }
}
